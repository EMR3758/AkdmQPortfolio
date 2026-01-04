using System;
using System.Collections.Generic;

namespace AkdmQPortfolio.Data
{
    public partial class AwardTable
    {
        public int AwardId { get; set; }
        public int? ProfilId { get; set; }
        public string? AwardName { get; set; }
        public string? Organization { get; set; }
        public int? Year { get; set; }
    }
}
