using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string state { get; set; }
        public int ? city { get; set; }
    }
}
