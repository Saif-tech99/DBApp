using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAppCodeLibrary.Models
{
    public class Recordes
    {
        public int Id { get; set; }
        public int ServProId { get; set; }
        public string Type { get; set; }
        public int FirstConMng { get; set; }
        public DateTime FirstCheckDate { get; set; }
        public int SecondConMng { get; set; }
        public DateTime SecondCheckDate { get; set; }
        public int RicId { get; set; }
        public int TotalCon { get; set; }

    }
}
