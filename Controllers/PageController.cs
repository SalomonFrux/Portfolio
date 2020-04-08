using Salomon_Porfolio.ViewModel;
using System;
using System.Net.Mail;
using System.Web.Mvc;

namespace Salomon_Porfolio.Controllers
{
    public class PageController : Controller
    {
        // GET: Mails
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void MailSender(ContactFormVm form)
        {
           


                var mailMessage = new MailMessage("keyassemahes@gmail.com", "keyassemahes@gmail.com", form.Email, form.Body);


                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new System.Net.NetworkCredential("keyassemahes@gmail.com", "Frux&KeyaSalomon")
                };
                client.EnableSsl = true;

                client.Send(mailMessage);





                var messageBody = "Hi! " + form.Name.ToUpper() + ", " + "<p>Thanks for getting in touch, I should personally attend to you within 24 hours.</p><p>However, For immediate assistance please contact me on WhatsApp at <strong>+13097414537</p></strong></p><p>Best Regards,<br/> Salomon K Sea <br/><strong>website: www.salomonfrux.cu.ma</strong></p>.";

                var mailFromMe = new MailMessage("fruxsalomon@gmail.com", form.Email, "From my contact form", messageBody);
                client.Credentials = new System.Net.NetworkCredential("fruxsalomon@gmail.com", "Frux&KeyaSalomon");

                mailFromMe.IsBodyHtml = true;
                client.Send(mailFromMe);

         


        }


        public ActionResult Blog()
        {
            return View("Blog");
        }
    }

}
