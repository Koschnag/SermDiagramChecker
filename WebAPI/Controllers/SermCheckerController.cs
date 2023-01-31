using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SermTreeCore.Contracts;
using System;
using WebAPI.DTO.Diagram;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SermCheckerController : Controller
    {
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Diagram diagram)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(diagram);
        }
    } 
}
