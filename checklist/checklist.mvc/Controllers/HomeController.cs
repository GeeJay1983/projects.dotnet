using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using checklist.mvc.Models;
using checklist.mvc.ViewModels;
using checklist;

namespace checklist.mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        
        public IActionResult Checklist()
        {
            var checklist = new Checklist();

            checklist.AddItem("Toilettas");
            checklist.AddItem("Schoenen");
            checklist.AddItem("Sokken");
            checklist.AddItem("Luiers");

            checklist.CheckItem(1);

            var checklistViewModel = new ChecklistViewModel(checklist);

            return View(checklistViewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
