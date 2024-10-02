using CodingTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
namespace CodingTest.Controllers
{
    

    public class AdminController : Controller
    {

        public IActionResult Index()
        {
                return View();
        }



        [HttpPost]
        public IActionResult Index(Elements elements)
        {
            // checks if input is valid
            if (ModelState.IsValid) {
                using (var db = new ElementsContext())
                {

                    // finds current maximum version number
                    int maxVersion = db.Elements.AsEnumerable() // Switch to client-side evaluation
                               .Select(e => e.Version)
                               .DefaultIfEmpty(0)
                               .Max();

                    // Increment the maximum version value by one
                    elements.Version = maxVersion + 1;
                    
                    // adds new element into database 
                    db.Add(elements);
                    //saves change to database
                    db.SaveChanges();
                }
            
            }

            return View();
        }
    }
    
}

