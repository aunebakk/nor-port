/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 1/12/2019 8:19:25 AM
  Template: sql2x.TemplateWithDurianGenerator.ContractUsing
*/
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SolutionNorSolutionPort.BusinessLogicLayer {
    public partial class AircraftContract {

        [DataMember()]
        public CrudeAircraftTypeRefContract AircraftTypeRef { get; set; }

        [DataMember()]
        public List<AircraftIdentifierIndexWithFilterContract> AircraftIdentifierIndexWithFilter { get; set; }

        [DataMember()]
        public List<AircraftCompartmentIndexWithFilterContract> AircraftCompartmentIndexWithFilter { get; set; }

        [DataMember()]
        public List<AircraftDocumentIndexWithFilterContract> AircraftDocumentIndexWithFilter { get; set; }

        [DataMember()]
        public CrudeProductContract Product { get; set; }
    }
}
