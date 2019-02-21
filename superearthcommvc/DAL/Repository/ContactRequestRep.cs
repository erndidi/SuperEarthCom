using superearthcommvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using superearthcommvc.DAL;
using System.Data.Entity;

namespace superearthcommvc.DAL.Repository
{
    public class ContactRequestRep
    {
        public ContactRequestRep()
        {

        }

        public List<ContactVM> GetAllNotContacted()
        {
            SuperEarthComEntities1 ctx = new SuperEarthComEntities1();
            return ctx.ContactRequests.Where(c => c.HasEngaged == false).Select(s => new ContactVM
            {
                Name = s.Name,
                Phone = s.Phone,
                Email = s.Email,
                CanText = s.CanText,
                Message = s.Message,
                HasEngaged = s.HasEngaged
            }).ToList();
        }



        public void Add(ContactVM contact)
        {
            SuperEarthComEntities1 ctx = new SuperEarthComEntities1();
            try
            {

                ctx.ContactRequests.Add(new ContactRequest
                {
                    CreateDate = DateTime.Now,
                    Email = contact.Email,
                    ID = Guid.NewGuid(),
                    Message = contact.Message,
                    Name = contact.Name,
                    Phone = contact.Phone,
                    CanText = contact.CanText,
                    HasEngaged = contact.HasEngaged

                });
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            

        }
    }
}