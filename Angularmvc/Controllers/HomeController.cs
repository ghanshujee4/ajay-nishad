using Angularmvc.Models;
using ContactUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Angularmvc.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index(int id = 0)
        //{
        //    ApplicationDbContext db = new ApplicationDbContext();
        //    tblA UserByid = db.tblAs.Find(id);
        //    if (UserByid == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(UserByid);
        //    //return View(db.tblAs.OrderByDescending(tblAs => tblAs.Datetime).Take(10).ToList());
        //}
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            return View(db.tblAs.OrderByDescending(tblAs => tblAs.Datetime).Take(10).ToList());
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Muzaffarpur()
        {
            return View();
        }
        public ActionResult Yojana()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactViewModel vm)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(vm.Email);//Email which you are getting 
								//from contact us page 
                    msz.To.Add("emailaddrss@gmail.com");//Where mail will be sent 
                    msz.Subject = vm.Subject;
                    msz.Body = vm.Message;
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = "smtp.gmail.com";

                    smtp.Port = 587;

                    smtp.Credentials = new System.Net.NetworkCredential
					("ghanshyam.jha@itcinfotech.com", "password");

                    smtp.EnableSsl = true;

                    smtp.Send(msz);

                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us ";
                }
                catch(Exception ex )
                {
                    ModelState.Clear();
                    ViewBag.Message = " Sorry we are facing Problem here {ex.Message}";
                }              
            }
          
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }

    }
}