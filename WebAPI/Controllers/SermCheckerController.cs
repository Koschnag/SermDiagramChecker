﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SermTreeCore.Contracts;
using System;
using WebAPI.DTO.Diagram;
using WebAPI.Wrapper;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SermCheckerController : Controller
    {
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Diagram diagram, Diagram solution)
        {
            if (ModelState.IsValid)
            {
                var tree = DiagramConverter.ConvertToTree(diagram);
                var solutionTree = DiagramConverter.ConvertToTree(solution);

                
                
                return Ok();
            }
            return Ok();
        }
    } 
}
