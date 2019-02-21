using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace superearthcommvc.Models
{
    public class ClientVM
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public string Phone { get; set; }   
        public bool HasEngaged { get; set; }
        public string Company { get; set; }
        public string Business { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
    }
}


