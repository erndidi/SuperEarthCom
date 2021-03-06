using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

public class AuthMessageSender : IEmailSender
    {
        public AuthMessageSender(EmailSettings emailSettings)
        {
            _emailSettings = emailSettings;
        }

        public EmailSettings _emailSettings { get; }

        public Task SendEmailAsync(string email, string subject, string message)
        {

            Execute (email, subject, message).Wait();
            return Task.FromResult(0);
        }

        public async Task Execute(string email, string subject, string message)
        {
          try
          {
            string toEmail = string.IsNullOrEmpty(email) 
                             ? _emailSettings.ToEmail 
                             : email;
            MailMessage mail = new MailMessage()
            {
                From = new MailAddress(_emailSettings.UsernameEmail, "Muhammad Hassan Tariq")
            };
            mail.To.Add(new MailAddress(toEmail));
            mail.CC.Add(new MailAddress(_emailSettings.CcEmail));

            mail.Subject = "Personal Management System - " + subject;
            mail.Body = message;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            using (SmtpClient smtp = new SmtpClient(_emailSettings.SecondayDomain, _emailSettings.SecondaryPort))
            {
                smtp.Credentials = new NetworkCredential(_emailSettings.UsernameEmail, _emailSettings.UsernamePassword);
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(mail);
            }
          }
          catch(Exception ex)
          {
             //do something here
          }
        }
    }