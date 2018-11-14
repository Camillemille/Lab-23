using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_21.Models;
 



namespace Lab_21.Controllers
{
    public class HomeController : Controller
    {
        public ItemTable newItemTable { get; private set; }
        public UserInfo newUserInfos { get; private set; }

        public ActionResult Index()
        {
            return View();
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

        public ActionResult Successful()
        {
            return View();
        }

        public ActionResult UserRegistration()
        {
            
            return View();
        }
        public ActionResult Registration(UserInfo newUser)
        {
           

            if (ModelState.IsValid)
            {

                CoffeeShopDBEntities userDatabase = new CoffeeShopDBEntities(); // Let's us do stuff with the classes
                userDatabase.UserInfoes.Add(newUser);
                userDatabase.SaveChanges();
                ViewBag.AddedItem = "Item was added sucessfully added";
                

                ViewData["ConfMessage"] = "Thanks " + newUser.FirstName;

                ViewBag.ConfMessage = "Thanks " + newUser.FirstName;

                return View("Successful");
            }

            else
            {
                return View("Error");

            }

        }
        
    }
}
