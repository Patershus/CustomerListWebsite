using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerListWebsite.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerListWebsite.Controllers
{
    public class CustomersController : Controller
    {
        

        public IActionResult Index()
        {
            var customers = DataManager.GetAllCustomers();
            ViewData["Customers"] = customers;        
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {

            DataManager.AddCustomer(customer);
            return RedirectToAction(nameof(CustomersController.Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var customer = DataManager.GetOneCustomer(id);
            ViewData["Customer"] = customer;
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
           
            DataManager.EditCustomer(customer, customer.Id);
            return RedirectToAction(nameof(CustomersController.Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = DataManager.GetOneCustomer(id);
            ViewData["Customer"] = customer;
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            DataManager.DeleteCustomer(customer.Id);
            return RedirectToAction(nameof(CustomersController.Index));
        }

        [HttpGet]
        public IActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            DataManager.AddCustomer(customer);
            return RedirectToAction(nameof(CustomersController.Index));
        }
    }
}
