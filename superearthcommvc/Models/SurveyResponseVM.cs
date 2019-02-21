using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace superearthcommvc.Models
{
    public class SurveyResponseVM
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int SurveyID { get; set; }
        public string ResponseString { get; set; }
        public List<string> Responses = new List<string>();
    }
}