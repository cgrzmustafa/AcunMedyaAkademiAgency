using AcunMedyaAkademiAgency.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Entities;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class CustomerController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult CustomerList()
        {
            var values = context.Customers.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();

            return RedirectToAction("CustomerList");
        }
        public ActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Find(id);
            context.Customers.Remove(value);
            context.SaveChanges();
            return RedirectToAction("CustomerList");
        }
        [HttpGet]
        public ActionResult UpdateCustomer(int id)
        {
            var value = context.Customers.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            var value = context.Customers.Find(customer.CustomerId);
            value.NameSurname = customer.NameSurname;
            value.ImageUrl = customer.ImageUrl;
            value.Hour = customer.Hour;
            context.SaveChanges();
            return RedirectToAction("CustomerList");
        }
    }
}