using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AddressId { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public  AddressModel address { get; set; }
    }
}
