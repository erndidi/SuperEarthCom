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
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.SurveyResponses = new HashSet<SurveyResponse>();
        }
    
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool CanText { get; set; }
        public string Phone { get; set; }
        public Nullable<bool> HasEngaged { get; set; }
        public string Company { get; set; }
        public string Business { get; set; }
        public string Title { get; set; }
        public string Specialty { get; set; }
        public string Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SurveyResponse> SurveyResponses { get; set; }
    }
}