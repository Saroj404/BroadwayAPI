using BroadwayAPI.CommonModel;
using BroadwayAPI.CommonServices;
using BroadwayAPI.Model;
using BroadwayAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BroadwayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BroadwaysRegisterController : ControllerBase
    {
        private readonly IRegisterService _registerService;
        private readonly IAuthorization _auth;
            public  BroadwaysRegisterController(IRegisterService registerservice,IAuthorization auth)
        {
            _registerService = registerservice;
            _auth = auth;
        
        }

        [HttpPost("Register")]
        public Task Register(ApplicationUser model)
        {
            return _registerService.RegisterAsync(model);

        }
        //public ActionResult GetToken(User model)
        //{
        //    var claims = new[]
        //    {
        //        new Claim(ClaimTypes.Name,model.UserName),
        //        new Claim(ClaimTypes.Role, "admin")
        //    };
        //    var jwtResult = _auth.GenerateTokens(model.UserName, claims, DateTime.Now);
        //    return Ok(new TokenResultant
        //    {
        //        UserName = model.UserName,
        //        AccessToken = jwtResult.AccessToken,
        //        RefreshToken = jwtResult.RefreshToken.TokenString,
        //        Role = null
        //    });

        //}

    }

}
