namespace superearthcommvc.Models
{
    public class ContactVM
    {
        public string Name{get;set;}
        public string Business { get; set; }
        public string Phone{get;set;}
        public bool CanText{get;set;}
        public string Email{get;set;}
        public string Message{get;set;}
        public bool? HasEngaged { get; set; }
    }
}