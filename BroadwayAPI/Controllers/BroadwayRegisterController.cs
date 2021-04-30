﻿using BroadwayAPI.Model;
using BroadwayAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroadwayAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BroadwayRegisterController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IRegisterService _registerService;
        public BroadwayRegisterController(ILogger<WeatherForecastController> logger, RegisterService registerService)
        {
            _logger = logger;
            _registerService = registerService;
        }


        [HttpPost("Register")]
        public Task Register(ApplicationUser model)
        {
            return _registerService.RegisterAsync(model);

        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
