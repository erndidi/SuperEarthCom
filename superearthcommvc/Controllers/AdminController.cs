using superearthcommvc.DAL;
using superearthcommvc.DAL.Repository;
using superearthcommvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.IO;
namespace superearthcommvc.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
  
        public JsonResult GetContractRequests(string input)
        {
            string pw = "D0ntd00th!$";
            string path = Server.MapPath("~/logs/log.txt");
            List<ContactVM> contacts= new List<ContactVM>();
            if (!string.IsNullOrEmpty(input.Trim()))
            {
                if (input == pw)
                {
                    try
                    {
                        ContactRequestRep rep = new ContactRequestRep();
                        contacts = rep.GetAllNotContacted();
                     
                    }
                    catch (Exception ex)
                    {
                        using (StreamWriter writer = new StreamWriter(path, true))
                        {
                            writer.WriteLine(string.Concat(DateTime.Now.ToLongDateString(), " :", ex.Message));
                        }
                     
                    }

                }


            }
            return Json(contacts, JsonRequestBehavior.AllowGet);


        }

        public ActionResult GetClientList()
        {
            SurveyRepo repo = new SurveyRepo();
            ClientSurveysVM clientSurveys = new ClientSurveysVM();
            clientSurveys.ClientSurveyList = repo.GetClientSurveys();
            return PartialView(clientSurveys);
        }

    }
}