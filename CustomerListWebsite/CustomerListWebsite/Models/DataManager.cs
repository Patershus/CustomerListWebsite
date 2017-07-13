using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerListWebsite.Models
{
    static public class DataManager
    {
        //Kommer inte att fungera? nyas upp hela tiden
        static int lastId = 4;
        private static List<Customer> customers = new List<Customer>
        {
            new Customer{Id=1, CompanyName="Acme", Adress="Stockholmsvägen", EmployeeCount=300},
            new Customer{Id=2, CompanyName="Warmkitten", Adress="Stockholm", EmployeeCount=1},
            new Customer{Id=3, CompanyName="Academy", Adress="Gatan", EmployeeCount=5},
            new Customer{Id=4, CompanyName="Academic work", Adress="KTH", EmployeeCount=10000},
        };

        public static Customer[] GetAllCustomers()
        {
            return customers.ToArray();
        }

        public static void AddCustomer(Customer customer)
        {
            //todo id?
            customer.Id = lastId + 1;

            customers.Add(customer);
            lastId++;

        }

        internal static Customer GetOneCustomer(int id)
        {

            return customers.Single(c => c.Id == id);
        }

        internal static void EditCustomer(Customer customerToEdit, int id)
        {
            var tempCustomer =customers
                .Single(c => c.Id == id);

            tempCustomer.Adress = customerToEdit.Adress;
            tempCustomer.CompanyName = customerToEdit.CompanyName;
            tempCustomer.EmployeeCount = customerToEdit.EmployeeCount;

        }

        internal static void DeleteCustomer(int id)
        {
            customers.RemoveAll(c => c.Id ==id);
        }
    }
}
