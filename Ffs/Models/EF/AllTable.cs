using System;
using System.Collections.Generic;

#nullable disable

namespace Ffs.Models.EF
{
    public partial class AllTable
    {
        public string KeyId { get; set; }
        public string TableId { get; set; }
        public double? RowId { get; set; }
        public string TestInput { get; set; }
        public string AcceptanceCriteria { get; set; }
    }
}
