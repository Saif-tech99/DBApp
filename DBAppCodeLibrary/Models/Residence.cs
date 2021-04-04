using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAppCodeLibrary.Models
{
    public class Residence
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public bool House { get; set; }
        public bool Apartement { get; set; }
        public bool Studio { get; set; }


    }
}
