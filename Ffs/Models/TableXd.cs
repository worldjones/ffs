using System;
using System.Collections.Generic;

#nullable disable

namespace Ffs.Models
{
    public partial class TableXd
    {
        public string KeyId { get; set; }
        public string TableId { get; set; }
        public string RowId { get; set; }
        public string TestInput { get; set; }
        public string AcceptanceCriteria { get; set; }
    }
}
