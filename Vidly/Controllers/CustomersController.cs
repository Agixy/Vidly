using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public partial class CustomersController : Controller
    {
        public List<Customer> CustomersList = new List<Customer>
        {
            new Customer{Id = 1, Name = "Pan Ośmiornica"},
            new Customer{Id = 2, Name = "Pan Żółw"}
        };


        // GET: Customers
        public virtual ActionResult Index()
        {
            var customList = CustomersList;

            var customersViewModel = new CustomersViewModel { AllCustomers = customList };

            return View(customersViewModel);
        }

        [Route("/{id}")]
        public virtual ActionResult Details(int id)
        {

            Customer customer = CustomersList.FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}