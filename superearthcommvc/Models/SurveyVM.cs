using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace superearthcommvc.Models
{
    public class SurveyVM
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public List<string> Questions = new List<string>();
        public string QuestionString { get; set; }
        public string ResponseString { get; set; }
        public List<string> Responses = new List<string>();

    }
}