using superearthcommvc.DAL.Repository;
using superearthcommvc.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace superearthcommvc.Controllers
{
    public class SurveyController : Controller
    {
        // GET: Survey
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Get(int cid, int sid)
        {
            SurveyRepo repo = new SurveyRepo();
            SurveyVM surveyvm = repo.GetSurvey(sid);
            surveyvm.ClientID = cid;
            return View(surveyvm);
        }
        [HttpGet]
        public ActionResult GetSurveyResponse(int surveyResponseID)
        {
            SurveyRepo repo = new SurveyRepo();
            ClientSurveyVM vm = repo.GetSurveyResponse(surveyResponseID);
            vm.Questions = vm.QuestionString.Split('?').Where(s => !string.IsNullOrEmpty(s)).ToList();
            vm.Responses = vm.ResponseString.Split('~').ToList();
         
            return PartialView(vm);
        }

        [HttpPost]
        public bool ProcessSurveyResponses(int clientid, int surveyid, string responses)
        {
            bool didProcess = true;
            string path = Server.MapPath("~/logs/log.txt");
            string reqPath = Server.MapPath("~/logs/request.txt");
            SurveyRepo repo = new SurveyRepo();
            SurveyResponseVM vm = new SurveyResponseVM { ClientID = clientid, SurveyID = surveyid, ResponseString = responses };
            try
            {
                repo.SubmitResponses(vm);
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(string.Concat(DateTime.Now.ToLongDateString(), " :", ex.Message));
                    didProcess = false;
                }
            }


            return didProcess;
        }

    }
}