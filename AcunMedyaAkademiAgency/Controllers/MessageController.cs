using AcunMedyaAkademiAgency.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Entities;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class MessageController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult MessageList()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();

            return RedirectToAction("MessageList");
        }
        public ActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }
        [HttpGet]
        public ActionResult UpdateMessage(int id)
        {
            var value = context.Messages.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateMessage(Message message)
        {
            var value = context.Messages.Find(message.MessageId);
            value.NameSurname = message.NameSurname;
            value.Email = message.Email;
            value.Title = message.Title;
            value.Description = message.Description;
            value.SendDate = message.SendDate;
            value.IsRead = message.IsRead;
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }
        public ActionResult SendMessage(Message c)
        {
            c.SendDate = DateTime.Now;
            c.IsRead = false;
            context.Messages.Add(c);
            context.SaveChanges();
            return Redirect("/Default/Index#message");
        }
    }
}