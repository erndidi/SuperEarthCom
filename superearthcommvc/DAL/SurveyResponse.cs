//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace superearthcommvc.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SurveyResponse
    {
        public int ID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<int> SurveyID { get; set; }
        public string Responses { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Survey Survey { get; set; }
    }
}