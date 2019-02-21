using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace superearthcomdotnet
{
    public class Utility
    {
        public static EmailSettings GetEmailSettings( string fromEmail)
        {
            return new EmailSettings
            {
                PrimaryDomain = "smtp.office365.com",
                PrimaryPort = 587,
                SecondayDomain = "smtp.office365.com",
                FromEmail = fromEmail,
                ToEmail = "ernest.lipford@superearthcom.com"
            };
        }
    }
}
