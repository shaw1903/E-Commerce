// using SendGrid's C# Library
// https://github.com/sendgrid/sendgrid-csharp
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace E_Commerce.Models
{
    public class SendMailModel
    {
        public string From { get; set; }
        public string ReturnEmailAddress { get; set; }
        public string FromName { get; set; }
        public string To { get; set; }
        public string ToName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string htmlMailContents { get; set; }
        [Display(Name = "Cc Email Address")]
        [EmailAddress]
        public string CcEmailAddress { get; set; }
        
        [Display(Name = "Bcc Email Address")]
        [EmailAddress]
        public string BccEmailAddress { get; set; }
    }
}