using System.Web;
using System.Web.Optimization;

namespace Web {
    public class BundleConfig {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Frameworks/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/Frameworks/jquery.validate*"));

            // highcharts
            bundles.Add(new ScriptBundle("~/bundles/highchart").Include(
                        "~/Scripts/Highcharts-4.0.1/js/highcharts.js"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you"re
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Frameworks/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/Frameworks/bootstrap.js",
                        "~/Scripts/Frameworks/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/site.css"));

        }
    }
}
