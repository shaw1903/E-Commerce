using System;
using System.Net.Mail;
using static System.Console;
using System.Collections.Generic;  
using System.Linq;   
using Microsoft.AspNetCore.Mvc;
using E_Commerce.Models;

namespace E_Commerce.Controllers 
{  
    public class SendMailController : Controller
    {  
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [Route("Contact")]
  
        public ViewResult Contact(SendMailModel _objModelMail) 
        {  
            if (ModelState.IsValid) 
            {  
                MailMessage mail = new MailMessage();  
                mail.To.Add("shawshawshaw@live.co.uk");  //Websites enquiry address.
                mail.From = new MailAddress("shawshawshaw@live.co.uk");  
                mail.Subject = $"Enquiry from WebPage Subject: {_objModelMail.Subject}";  
                string Body = $"You have recieved an enquiry from your contact page, mail contents: \nName: {_objModelMail.FromName} \nReturn Mail Address: {_objModelMail.ReturnEmailAddress} \nEnquiry: \n{_objModelMail.Body}";  
                mail.Body = Body;  
                mail.IsBodyHtml = false;  
                SmtpClient smtp = new SmtpClient();  
                smtp.Host = "smtp-mail.outlook.com";  
                smtp.Port = 587;  
                smtp.UseDefaultCredentials = false;  
                smtp.Credentials = new System.Net.NetworkCredential("shawshawshaw@live.co.uk", "Aberdeen1903"); // Enter senders User name and password  
                smtp.EnableSsl = true;  
                try
                {
                    smtp.Send(mail); 
                    WriteLine("Email Sending was successful."); 
                    ModelState.Clear();
                    return View();                     
                }

                catch (Exception ex)
                {
                    WriteLine("Exception caught in CreateMessageWithAttachment(): {0}",
                    ex.ToString());
                    return View("Contact", _objModelMail); 
                }
            
            } 
            else
            {  
                return View();  
            }  
        }  
    }  
}  