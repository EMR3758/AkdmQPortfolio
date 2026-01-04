using System;
using System.Collections.Generic;

namespace AkdmQPortfolio.Data
{
    public partial class EducationTable
    {
        public int EducationId { get; set; }
        public int? ProfileId { get; set; }
        public string? Degree { get; set; }
        public string? School { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
    }
}
