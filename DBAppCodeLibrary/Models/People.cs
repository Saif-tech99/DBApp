using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAppCodeLibrary.Models
{
   public  class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Male { get; set; }
        public bool Female { get; set; }
        public int ResidenceId { get; set; }
        public bool Owner { get; set; }
        public bool Tenant { get; set; }

    }
}
