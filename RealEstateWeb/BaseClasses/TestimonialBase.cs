using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Components;
using MimeKit;
using MimeKit.Text;
using RealEstateWeb.Models;
using System.Threading.Tasks;

namespace RealEstateWeb.BaseClasses
{
    public class TestimonialBase : ComponentBase
    {
        public Testimonial Testimonial { get; set; } = new Testimonial();

        public string TestimonialRating { get; set; }
        public bool TestimonialSent { get; set; }

        public bool dialogTestimonialIsOpen { get; set; }

        public void OpenTestimonialDialog()
        {
            dialogTestimonialIsOpen = true;
        }

        public void onChangeStar(ChangeEventArgs args)
        {
            TestimonialRating = args.Value.ToString();

        }

        protected async Task HandleValidSubmit()
        {
            var testimonialDetails = Testimonial;
            testimonialDetails.Rating = TestimonialRating;
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse("learnaspnet715@gmail.com");
            email.To.Add(MailboxAddress.Parse("nirjhar18@gmail.com"));
            email.Subject = "Test Email Subject";
            email.Body = new TextPart(TextFormat.Plain) { Text = "Example Plain Text Message Body" };

            // send email
            using var smtp = new SmtpClient();
            await smtp.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync("learnaspnet715@gmail.com", "pulsar810");

            await smtp.SendAsync(email);

            TestimonialSent = true;
            smtp.Disconnect(true);
            reset();
        }
        public void reset()
        {
            Testimonial = new Testimonial();
        }

    }
}
