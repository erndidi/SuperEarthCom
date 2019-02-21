using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace superearthcommvc.Models
{
    public class ClientSurveyVM
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int ClientID { get; set; }
        public int SurveyID { get; set; }
        public int? SurveyResponseID { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public string Phone { get; set; }      
        public string Status { get; set; }
        public List<string> Questions = new List<string>();
        public string QuestionString { get; set; }
        public string ResponseString { get; set; }
        public List<string> Responses = new List<string>();
     
    }

    public class ClientSurveysVM
    {
        public List<ClientSurveyVM> ClientSurveyList = new List<ClientSurveyVM>();
    }
}