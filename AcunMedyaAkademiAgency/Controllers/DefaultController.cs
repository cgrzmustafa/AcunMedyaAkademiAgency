using AcunMedyaAkademiAgency.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class DefaultController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult ProjectPartial()
        {
            var values = context.Projects.OrderByDescending(x => x.ProjectId).Take(6).ToList();
            return PartialView(values);
        }
        public PartialViewResult ModalPartial()
        {
            var values = context.ProjectDetails.ToList();
            return PartialView(values);
        }
        public PartialViewResult TeamPartial()
        {
            var values = context.Teams.OrderBy(x => x.TeamId).Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult SocialMediaPartial()
        {
            var values = context.SocialMedias.ToList();
            return PartialView(values);
        }
        public PartialViewResult FeaturePartial()
        {
            return PartialView();
        }
        public PartialViewResult ServicePartial()
        {
            var values = context.Services.OrderByDescending(x => x.ServiceId).Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutPartial()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult ClientPartial()
        {
            return PartialView();
        }
        public PartialViewResult MessagePartial()
        {
            return PartialView();
        }
        public PartialViewResult MapPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult JSPartial()
        {
            return PartialView();
        }
    }
}