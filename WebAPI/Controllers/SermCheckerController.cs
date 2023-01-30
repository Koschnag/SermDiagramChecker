using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SermTreeCore.Contracts;
using System;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SermCheckerController : Controller
    {
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("name")] ITree person)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }
    }
}
