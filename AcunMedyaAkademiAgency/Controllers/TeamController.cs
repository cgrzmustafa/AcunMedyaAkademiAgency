using AcunMedyaAkademiAgency.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Entities;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class TeamController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult TeamList()
        {
            var values = context.Teams.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTeam()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTeam(Team team)
        {
            context.Teams.Add(team);
            context.SaveChanges();

            return RedirectToAction("TeamList");
        }
        public ActionResult DeleteTeam(int id)
        {
            var value = context.Teams.Find(id);
            context.Teams.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TeamList");
        }
        [HttpGet]
        public ActionResult UpdateTeam(int id)
        {
            var value = context.Teams.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTeam(Team team)
        {
            var value = context.Teams.Find(team.TeamId);
            value.NameSurname = team.NameSurname;
            value.ImageUrl = team.ImageUrl;
            value.Gender = team.Gender;
            value.City = team.City;
            value.BranchId = team.BranchId;
            context.SaveChanges();
            return RedirectToAction("TeamList");
        }
    }
}