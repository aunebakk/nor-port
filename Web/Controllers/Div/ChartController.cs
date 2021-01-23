using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using SolutionNorSolutionPort.BusinessLogicLayer;
using SolutionNorSolutionPort.AspMvc.Controllers;

// https://csharptrenches.wordpress.com/2013/08/21/how-to-use-highcharts-js-with-asp-net-mvc-4/

namespace HighlightsChart.Controllers
{

    class UserActivities
    {
        public string Day { get; set; }
        public int Activities { get; set; }
    }

    class BookingStatistics
    {
        public string Day { get; set; }
        public int Passengers { get; set; }
        public int Adults { get; set; }
        public int Childs { get; set; }
        public int Infants { get; set; }
    }

    class TransactionsBalance
    {
        public string Day { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
    }

    class PerformanceTime
    {
        public string Date { get; set; }
        public int Milliseconds { get; set; }
    }

    public class ChartController : Controller
    {
        public ActionResult UserActivityIndex() {
            Logging.ActionLog(Request, "UserActivityIndex ( ASP MVC WCF )");

            List<DefaultStatisticsContract> statistics = new DefaultSearchServiceClient().DefaultStatistics();

            //create a collection of data
            var transactionCounts = new List<UserActivities>();

            foreach ( DefaultStatisticsContract contract in statistics ) {
                transactionCounts.Add(
                    new UserActivities() {
                        Day = contract.ActivityDate.Substring(3, 5),
                        Activities = contract.DayCount
                    }
                    );
            }

            // modify data type to make it of array type
            var xDataMonths = transactionCounts.Select(i => i.Day).ToArray();
            var yDataCounts = transactionCounts.Select(i => new object[] { i.Activities }).ToArray();

            // instantiate an object of the High charts type
            var chart = new Highcharts("chart")

            // define the type of chart 
            .InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })

            // overall Title of the chart 
            .SetTitle(new Title { Text = "History" })

            // small label below the main Title
            .SetSubtitle(new Subtitle { Text = "User Activities" })

            // load the X values
            .SetXAxis(new XAxis { Categories = xDataMonths })

            // set the Y title
            .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Number of Transactions" } })
            .SetTooltip(new Tooltip {
                Enabled = true,
                Formatter = @"function() { return '<b>'+ this.series.name +'</b><br/>'+ this.x +': '+ this.y; }"
            })
            .SetPlotOptions(new PlotOptions {
                Line = new PlotOptionsLine {
                    DataLabels = new PlotOptionsLineDataLabels {
                        Enabled = true
                    },
                    EnableMouseTracking = false
                }
            })
                //load the Y values 
               .SetSeries(new[]
                    {
                        new Series {Name = "Transactions", Data = new Data(yDataCounts)},
                            //you can add more y data to create a second line
                            // new Series { Name = "Other Name", Data = new Data(OtherData) }
                    });

            return View(chart);
        }

        public ActionResult BookingStatisticsIndex() {
            Logging.ActionLog(Request, "BookingStatisticsIndex ( ASP MVC WCF )");
            DateTime fromDateTime = DateTime.UtcNow.AddDays(-20);
            DateTime untilDateTime = DateTime.UtcNow.AddDays(+20);

            List<BookingStatisticsContract> statistics = 
                new BookingSearchServiceClient().BookingStatistics(
                    Guid.Empty,
                    Guid.Empty,
                    fromDateTime,
                    untilDateTime
                    );

            // create a collection of data
            var statisticsCounts = new List<BookingStatistics>();

            foreach ( BookingStatisticsContract contract in statistics ) {
                statisticsCounts.Add(
                    new BookingStatistics() {
                        Day = contract.Date.ToString("yyyyMMdd"),
                        Passengers = contract.PassengersBookedCount,
                        Adults = contract.AdultBookedCount,
                        Childs = contract.ChildBookedCount,
                        Infants = contract.InfantBookedCount
                    }
                    );
            }

            // modify data type to make it of array type
            var xDataMonths = statisticsCounts.Select(i => i.Day).ToArray();
            var yDataPassengers = statisticsCounts.Select(i => new object[] { i.Passengers }).ToArray();
            var yDataAdults = statisticsCounts.Select(i => new object[] { i.Adults }).ToArray();
            var yDataChildren = statisticsCounts.Select(i => new object[] { i.Childs }).ToArray();
            var yDataInfants = statisticsCounts.Select(i => new object[] { i.Infants }).ToArray();

            // instantiate an object of the High charts type
            var chart = new Highcharts("chart")

                // define the type of chart 
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })

                // overall Title of the chart 
                .SetTitle(new Title { Text = "nor-port" })

                // small label below the main Title
                .SetSubtitle(new Subtitle { Text = "Bookings from " + fromDateTime.ToShortDateString() + " until " + untilDateTime.ToShortDateString() })

                // load the X values
                .SetXAxis(new XAxis { Categories = xDataMonths })

                // set the Y title
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Bookings" } })
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Adults" } })
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Children" } })
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Infants" } })
                .SetTooltip(
                    new Tooltip {
                        Enabled = true,
                        Formatter = @"function() { return '<b>'+ this.series.name +'</b><br/>'+ this.x +': '+ this.y; }"
                    })
                    .SetPlotOptions(new PlotOptions {
                        Line = new PlotOptionsLine {
                            DataLabels = new PlotOptionsLineDataLabels {
                                Enabled = true
                            },
                            EnableMouseTracking = false
                        }
                    })

                    // load the Y values 
                    .SetSeries(new[]
                        {   new Series { Name = "Bookings", Data = new Data(yDataPassengers) },
                            new Series { Name = "Adults", Data = new Data(yDataAdults) },
                            new Series { Name = "Children", Data = new Data(yDataChildren) },
                            new Series { Name = "Infants", Data = new Data(yDataInfants) }
                            });

            return View(chart);
        }

        public ActionResult TransactionsBalance() {
            Logging.ActionLog(Request, "TransactionsBalance ( ASP MVC WCF )");
            DateTime fromDateTime = DateTime.UtcNow.AddMonths(-1);
            DateTime untilDateTime = DateTime.UtcNow.AddDays(+5);

            List<TransactionsCreditDebitBalanceContract> statistics = 
                new FinancialSearchServiceClient().TransactionsCreditDebitBalance(
                    fromDateTime,
                    untilDateTime
                    );

            // create a collection of data
            var transactionsBalance = new List<TransactionsBalance>();

            foreach ( TransactionsCreditDebitBalanceContract contract in statistics ) {
                transactionsBalance.Add(
                    new TransactionsBalance() {
                        Day = contract.Date,
                        Credit = contract.CreditAmount,
                        Debit = contract.DebitAmount
                    }
                    );
            }

            // modify data type to make it of array type
            var xDataMonths = transactionsBalance.Select(i => i.Day).ToArray();
            var yDataCredit = transactionsBalance.Select(i => new object[] { i.Credit.ToString("f0") }).ToArray();
            var yDataDebit = transactionsBalance.Select(i => new object[] { i.Debit.ToString("f0") }).ToArray();

            // instantiate an object of the High charts type
            var chart = new Highcharts("chart")

                // define the type of chart 
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })

                // overall Title of the chart 
                .SetTitle(new Title { Text = "nor-port" })

                // small label below the main Title
                .SetSubtitle(new Subtitle { Text = "Days from " + fromDateTime.ToShortDateString() + " until " + untilDateTime.ToShortDateString() })

                // load the X values
                .SetXAxis(new XAxis { Categories = xDataMonths })

                // set the Y title
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Credit" } })
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Debit" } })
                .SetTooltip(
                    new Tooltip {
                        Enabled = true,
                        Formatter = @"function() { return '<b>'+ this.series.name +'</b><br/>'+ this.x +': '+ this.y; }"
                    })
                    .SetPlotOptions(new PlotOptions {
                        Line = new PlotOptionsLine {
                            DataLabels = new PlotOptionsLineDataLabels {
                                Enabled = true
                            },
                            EnableMouseTracking = false
                        }
                    })

                    // load the Y values 
                    .SetSeries(new[]
                        {   new Series { Name = "Credit", Data = new Data(yDataCredit) },
                            new Series { Name = "Debit", Data = new Data(yDataDebit) }
                            });

            return View(chart);
        }

        public ActionResult PerformanceTimes(
            string commandName
            ) {
            Logging.ActionLog(Request, commandName + " ( ASP MVC WCF )");

            DateTime fromDateTime = DateTime.UtcNow.AddMonths(-1);
            DateTime untilDateTime = DateTime.UtcNow.AddDays(+5);

            List<DefaultPerformanceTimesContract> times = 
                new DefaultSearchServiceClient().DefaultPerformanceTimes(
                    commandName
                    );

            // create a collection of data
            var performanceTimes = new List<PerformanceTime>();

            foreach ( DefaultPerformanceTimesContract contract in times ) {
                performanceTimes.Add(
                    new PerformanceTime() {
                        Date = contract.DateTime.ToString("ss"),
                        Milliseconds = contract.Milliseconds
                    }
                    );
            }

            // modify data type to make it of array type
            var xDataTimes = performanceTimes.Select(i => i.Date).ToArray();
            var yDataMilliseconds = performanceTimes.Select(i => new object[] { i.Milliseconds.ToString() }).ToArray();

            // instantiate an object of the High charts type
            var chart = new Highcharts("chart")

                // define the type of chart 
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })

                // overall Title of the chart 
                .SetTitle(new Title { Text = "nor-port" })

                // small label below the main Title
                .SetSubtitle(new Subtitle { Text = commandName + " from " + fromDateTime.ToShortDateString() + " until " + untilDateTime.ToShortDateString() })

                // load the X values
                .SetXAxis(new XAxis { Categories = xDataTimes })

                // set the Y title
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Milliseconds" } })
                .SetTooltip(
                    new Tooltip {
                        Enabled = true,
                        Formatter = @"function() { return '<b>'+ this.series.name +'</b><br/>'+ this.x +': '+ this.y; }"
                    })
                    .SetPlotOptions(new PlotOptions {
                        Line = new PlotOptionsLine {
                            DataLabels = new PlotOptionsLineDataLabels {
                                Enabled = true
                            },
                            EnableMouseTracking = false
                        }
                    })

                    // load the Y values 
                    .SetSeries(new[]
                        {   new Series { Name = "Milliseconds", Data = new Data(yDataMilliseconds) }
                        });

            return View(chart);
        }

        [HttpPost]
        public ActionResult PerformanceTimesAndCombo(
            string commandName,
            Guid? dillToDiffrentiateFromHttpGet
            ) {
            Logging.ActionLog(Request, "PerformanceTimesAndCombo: " + commandName + " ( ASP MVC WCF )");

            //Response.AddHeader("Chart", $"PerformanceTimesAndCombo?commandName={commandName}");

            DateTime fromDateTime = DateTime.UtcNow.AddMonths(-1);
            DateTime untilDateTime = DateTime.UtcNow.AddDays(+5);

            List<DefaultPerformanceTimeCommandsContract> commands = 
                new DefaultSearchServiceClient().DefaultPerformanceTimeCommands();

            ViewBag.CommandName =
                new SelectList(
                    commands.Select(x => new { x.CommandName, x.CommandDisplayName }).Distinct().OrderBy(x => x.CommandDisplayName),
                    "CommandName",
                    "CommandDisplayName",
                    commandName
                    );

            List<DefaultPerformanceTimesContract> times = 
                new DefaultSearchServiceClient().DefaultPerformanceTimes(
                    commandName
                    );

            // to get lesser dates first in graph
            times.Reverse();

            // get exact time period
            if (times.Count > 2) {
                fromDateTime = times.First().DateTime;
                untilDateTime = times.Last().DateTime;
            }

            // create a collection of data
            var performanceTimes = new List<PerformanceTime>();

            foreach ( DefaultPerformanceTimesContract contract in times ) {
                performanceTimes.Add(
                    new PerformanceTime() {
                        Date = contract.DateTime.ToString("hh:mm:ss"),
                        Milliseconds = contract.Milliseconds
                    }
                    );
            }

            // modify data type to make it of array type
            var xDataTimes = performanceTimes.Select(i => i.Date).ToArray();
            var yDataMilliseconds = performanceTimes.Select(i => new object[] { i.Milliseconds.ToString() }).ToArray();

            // instantiate an object of the High charts type
            var chart = new Highcharts("chart")

                // define the type of chart 
                .InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })

                // overall Title of the chart 
                .SetTitle(new Title { Text = "nor-port" })

                // small label below the main Title
                .SetSubtitle(new Subtitle { Text = commandName + " from " + fromDateTime 
                                                               + " until " + untilDateTime
                                            })

                // load the X values
                .SetXAxis(new XAxis { Categories = xDataTimes })

                // set the Y title
                .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Milliseconds" } })
                .SetTooltip(
                    new Tooltip {
                        Enabled = true,
                        Formatter = @"function() { return '<b>'+ this.series.name +'</b><br/>'+ this.x +': '+ this.y; }"
                    })
                    .SetPlotOptions(new PlotOptions {
                        Line = new PlotOptionsLine {
                            DataLabels = new PlotOptionsLineDataLabels {
                                Enabled = true
                            },
                            EnableMouseTracking = false
                        }
                    })

                    // load the Y values 
                    .SetSeries(new[]
                        {   new Series { Name = "Milliseconds", Data = new Data(yDataMilliseconds) }
                        });

            RedirectToAction("PerformanceTimesAndCombo", new { commandName = commandName });

            return View(chart);
        }

        [HttpGet]
        public ActionResult PerformanceTimesAndCombo(
            string commandName
            ) {
            Logging.ActionLog(Request, "PerformanceTimesAndCombo: " + commandName + " ( ASP MVC WCF )");

            return PerformanceTimesAndCombo(commandName, dillToDiffrentiateFromHttpGet: null);

            //DateTime fromDateTime = DateTime.UtcNow.AddMonths(-1);
            //DateTime untilDateTime = DateTime.UtcNow.AddDays(+5);

            //List<DefaultPerformanceTimeCommandsContract> commands = 
            //    new DefaultSearchServiceClient().DefaultPerformanceTimeCommands();

            //ViewBag.CommandName =
            //    new SelectList(
            //        commands.Select(x => new { x.CommandName, x.CommandDisplayName }).Distinct(),
            //        "CommandName",
            //        "CommandDisplayName",
            //        commandName
            //        );

            //List<DefaultPerformanceTimesContract> times = 
            //    new DefaultSearchServiceClient().DefaultPerformanceTimes(
            //        commandName
            //        );

            //// create a collection of data
            //var performanceTimes = new List<PerformanceTime>();

            //foreach ( DefaultPerformanceTimesContract contract in times ) {
            //    performanceTimes.Add(
            //        new PerformanceTime() {
            //            Date = contract.DateTime.ToString("ss"),
            //            Milliseconds = contract.Milliseconds
            //        }
            //        );
            //}

            //// modify data type to make it of array type
            //var xDataTimes = performanceTimes.Select(i => i.Date).ToArray();
            //var yDataMilliseconds = performanceTimes.Select(i => new object[] { i.Milliseconds.ToString() }).ToArray();

            //// instantiate an object of the High charts type
            //var chart = new Highcharts("chart")

            //    // define the type of chart 
            //    .InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })

            //    // overall Title of the chart 
            //    .SetTitle(new Title { Text = "nor-port" })

            //    // small label below the main Title
            //    .SetSubtitle(new Subtitle { Text = commandName + " from " + fromDateTime.ToShortDateString() + " until " + untilDateTime.ToShortDateString() })

            //    // load the X values
            //    .SetXAxis(new XAxis { Categories = xDataTimes })

            //    // set the Y title
            //    .SetYAxis(new YAxis { Title = new YAxisTitle { Text = "Milliseconds" } })
            //    .SetTooltip(
            //        new Tooltip {
            //            Enabled = true,
            //            Formatter = @"function() { return '<b>'+ this.series.name +'</b><br/>'+ this.x +': '+ this.y; }"
            //        })
            //        .SetPlotOptions(new PlotOptions {
            //            Line = new PlotOptionsLine {
            //                DataLabels = new PlotOptionsLineDataLabels {
            //                    Enabled = true
            //                },
            //                EnableMouseTracking = false
            //            }
            //        })

            //        // load the Y values 
            //        .SetSeries(new[]
            //            {   new Series { Name = "Milliseconds", Data = new Data(yDataMilliseconds) }
            //            });

            //return View(chart);
        }
    }
}
