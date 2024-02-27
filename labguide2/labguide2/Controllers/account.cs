using labguide2.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace labguide2.Controllers
{
    public class account : Controller
    {
        public IActionResult Index()
        {
            List<account> acc = new List<account>();
            account account = new account() { 
            ID = 1, name = "tung", Phone = "0976727372", Gender = 1, Adress = "39 nguyen dinh chieu", Bio = "hpg", Birthday = "30/4/1975"

                };

            ViewBag.Account = account;

        
        
                  return View();
        }
    }
}
