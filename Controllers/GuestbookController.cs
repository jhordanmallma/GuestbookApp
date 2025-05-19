using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using MiPrimeraAppWeb.Interfaces;
using MiPrimeraAppWeb.Models;

namespace MiPrimeraAppWeb.Controllers
{
    public class GuestbookController : Controller
    {
        private readonly IWelcomeService _welcome;
        private readonly IGuestbookService _store;

        public GuestbookController(IWelcomeService welcome, IGuestbookService store)
        {
            _welcome = welcome;
            _store = store;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Message = _welcome.GetWelcomeMessage();
            return View();
        }

        [HttpPost]
        public IActionResult Create(GuestEntry model)
        {
            // Logging for debugging purposes
            Console.WriteLine("----- Entramos al POST Create -----");
            Console.WriteLine($"Name: '{model?.Name}', Message: '{model?.Message}'");
            Console.WriteLine($"ModelState.IsValid = {ModelState.IsValid}");
            foreach (var kv in ModelState)
            {
                Console.WriteLine($"  Key = {kv.Key}, Errors = {kv.Value.Errors.Count}");
            }
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine("  Error: " + error.ErrorMessage);
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _store.AddEntry(model);

            // Directly return List view for immediate verification
            var all = _store.GetAll();
            return View("List", all);
        }

        [HttpGet]
        public IActionResult List()
        {
            var all = _store.GetAll();
            return View(all);
        }
    }
}
