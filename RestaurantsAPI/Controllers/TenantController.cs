﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Commons.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantsAPI.Controllers
{
    [Route("api/[controller]")]
    public class TenantController : Controller
    {

        [HttpPost]
        public IActionResult Register([FromBody] RegisterTenantDTO registerDTO)
        {
            return Ok();
        }
    }
}
