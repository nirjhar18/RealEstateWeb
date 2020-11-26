using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using MimeKit;
using RealEstateWeb.Models;
using System.Threading.Tasks;

namespace RealEstateWeb.BaseClasses
{
    public class ContactUsBase : ComponentBase
    {
        [Inject]
        public IConfiguration _configuration { get; set; }

        public ContactUs ContactUs { get; set; } = new ContactUs();

        public bool EmailSent { get; set; }

        protected async Task HandleValidSubmit()
        {

            var username = _configuration["EmailDetails:username"];
            var password = _configuration["EmailDetails:password"];

            var contactDetails = ContactUs;
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse("learnaspnet715@gmail.com");
            email.To.Add(MailboxAddress.Parse("nirjhar18@gmail.com"));
            email.Subject = "Contact Through Website";
            var builder = new BodyBuilder();
            builder.HtmlBody = string.Format(@"<p>Hi Ben, Please find the details from the contact form<br>
                               <p>Email      :  {0}<br>
                               <p>Name       :  {1}<br>
                               <p>PhoneNumber:  {2}<br>
                               <p>Message    :  {3}<br>", contactDetails.Email, contactDetails.Name,
                               contactDetails.PhoneNumber, contactDetails.Message);

            email.Body = builder.ToMessageBody();

            // send email
            using var smtp = new SmtpClient();
            await smtp.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(username, password);

            await smtp.SendAsync(email);

            EmailSent = true;
            smtp.Disconnect(true);
            reset();
        }
        public void reset()
        {
            ContactUs = new ContactUs();
        }

    }
}
