using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;
using superearthcommvc.Models;
using superearthcommvc.DAL.Repository;

namespace superearthcomdotnet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public ActionResult Contact(ContactVM contact)
        {


            return View();
        }

       
        [HttpPost]
        public bool SendEmail(ContactVM contact)
        {
            bool sentSucceeded = true;
            string path = Server.MapPath("~/logs/log.txt");
            string reqPath = Server.MapPath("~/logs/request.txt");
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(contact.Email);

                message.To.Add(new MailAddress("ernest.lipford@superearthcom.com"));

                message.Subject = "potentianl client";
                message.Body = contact.Message;

                SmtpClient client = new SmtpClient();
                client.Send(message);

            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(string.Concat(DateTime.Now.ToLongDateString(), " :", ex.Message));
                    sentSucceeded = false;
                }
            }

            return sentSucceeded;
        }

        void CreateRequest(ContactVM contact)
        {
            ContactRequestRep rep = new ContactRequestRep();
            contact.HasEngaged = false;
            rep.Add(contact);
        }



    }
}
