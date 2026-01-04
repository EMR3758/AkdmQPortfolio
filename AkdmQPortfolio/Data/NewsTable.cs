using System;
using System.Collections.Generic;

namespace AkdmQPortfolio.Data
{
    public partial class NewsTable
    {
        public int NewsId { get; set; }
        public DateTime? PublishDate { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
}
