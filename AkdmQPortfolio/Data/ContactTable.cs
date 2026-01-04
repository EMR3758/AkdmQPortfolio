using System;
using System.Collections.Generic;

namespace AkdmQPortfolio.Data
{
    public partial class ContactTable
    {
        public int ContactId { get; set; }
        public string? PhoneSecondary { get; set; }
        public string? PhonePrimary { get; set; }
        public string? Adress { get; set; }
        public string? EmailPrimary { get; set; }
        public string? EmailSecondary { get; set; }
        public string? Icon { get; set; }
    }
}
