﻿using Microsoft.AspNetCore.Mvc;

namespace jurosAPI.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "https://www.google.com";
        }
    }
}