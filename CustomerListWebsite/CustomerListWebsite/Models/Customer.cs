using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerListWebsite.Models
{
    public class Customer
    {
        
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Adress { get; set; }
        public int EmployeeCount { get; set; }

       
    }
}
