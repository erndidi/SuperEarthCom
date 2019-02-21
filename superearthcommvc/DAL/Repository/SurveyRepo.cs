using superearthcommvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace superearthcommvc.DAL.Repository
{
    public class SurveyRepo
    {
        public SurveyVM GetSurvey(int id)
        {
            SuperEarthComEntities1 ctx = new SuperEarthComEntities1();
            SurveyVM vm = ctx.Surveys.Where(s => s.ID == id).Select(s => new SurveyVM
            {
                ID = s.ID,
                QuestionString = s.Questions

            }).SingleOrDefault();

            vm.Questions = vm.QuestionString.Split('?').Where(q => !string.IsNullOrWhiteSpace(q)).ToList();

            return vm;

        }

        public Error SubmitResponses(SurveyResponseVM vm)
        {
            SuperEarthComEntities1 ctx = new SuperEarthComEntities1();
            Error err = new Error { NoError = true, Message = string.Empty };
            try
            {
                ctx.SurveyResponses.Add(new SurveyResponse
                {
                    ClientID = vm.ClientID,
                    SurveyID = vm.SurveyID,
                    Responses = vm.ResponseString,
                    CreateDate = DateTime.Now
                });
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                err.NoError = false;
                err.Message = ex.Message;
            }

            return err;
        }

        public ClientSurveyVM GetSurveyResponse(int surveyResponseId)
        {
            SuperEarthComEntities1 ctx = new SuperEarthComEntities1();
            ClientSurveyVM vm = (from c in ctx.Clients
                                 join sr in ctx.SurveyResponses
                                 on c.ID equals sr.ClientID
                                 join s in ctx.Surveys
                                 on sr.SurveyID equals s.ID
                                 where sr.ID == surveyResponseId
                                 select new ClientSurveyVM
                                 {
                                     ClientID = c.ID,
                                     SurveyID = s.ID,
                                     SurveyResponseID = sr.SurveyID,
                                     FirstName = c.FirstName,
                                     MiddleName = c.MiddleName,
                                     LastName = c.LastName,
                                     CreateDate = sr.CreateDate,
                                     QuestionString = s.Questions,
                                     ResponseString = sr.Responses
                                 }).SingleOrDefault();
            return vm;
        }

        public List<ClientSurveyVM> GetClientSurveys()
        {
            SuperEarthComEntities1 ctx = new SuperEarthComEntities1();
            List<ClientSurveyVM> clientSurveys = (from c in ctx.Clients
                                                  join sr in ctx.SurveyResponses
                                                  on c.ID equals sr.ClientID
                                                  join s in ctx.Surveys
                                                  on sr.SurveyID equals s.ID
                                                  select new ClientSurveyVM
                                                  {
                                                      ClientID = c.ID,
                                                      SurveyID = s.ID,
                                                      SurveyResponseID = sr.SurveyID,
                                                      FirstName = c.FirstName,
                                                      MiddleName = c.MiddleName,
                                                      LastName = c.LastName,
                                                      CreateDate = sr.CreateDate
                                                  }).ToList();
            return clientSurveys;

        }
    }
}