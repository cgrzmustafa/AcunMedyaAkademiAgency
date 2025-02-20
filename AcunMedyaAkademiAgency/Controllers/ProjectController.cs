using AcunMedyaAkademiAgency.Context;
using AcunMedyaAkademiAgency.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class ProjectController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult ProjectList(string searchText)
        {
            List<Project> values;
            if(searchText != null)
            {
                values = context.Projects.Where(x => x.Title.Contains(searchText)).ToList();
                return View(values);
            }

            values = context.Projects.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            List<SelectListItem> values1 = (from x in context.Categories.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.CategoryName,
                                                Value = x.CategoryId.ToString()
                                            }).ToList();
            ViewBag.v = values1;
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(Project project)
        {
            context.Projects.Add(project);
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
    }
}