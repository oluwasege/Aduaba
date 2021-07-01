using Aduaba.DTO;
using Aduaba.DTO.Account;
using Aduaba.Services;
using Aduaba.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        private readonly ICategoryServices _categoryServices;
        public UserController(IUserServices userServices,ICategoryServices categoryServices)
        {
            _userServices = userServices;
            _categoryServices = categoryServices;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginRequest model)
        {
            var result = await _userServices.LoginAsync(model);
            SetRefreshTokenInCookie(result.RefreshToken);
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync([FromBody]RegisterRequest model)
        {

            var result = await _userServices.RegisterAsync(model);
            return Ok(result);
        }

        private void SetRefreshTokenInCookie(string refreshToken)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(10),
            };

            Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);
        }
       

        [HttpPost("refresh-t")]
        public async Task<IActionResult> RefreshToken()
        {
            var refreshToken = Request.Cookies["refreshToken"];
            var response = await _userServices.RefreshTokenAsync(refreshToken);
            if (!string.IsNullOrEmpty(response.RefreshToken))
                SetRefreshTokenInCookie(response.RefreshToken);
            return Ok(response);
        }

        [HttpPost("revoke-token")]
        public IActionResult RevokeToken()
        {
            // accept token from request body or cookie
            var token =  Request.Cookies["refreshToken"];
            if (string.IsNullOrEmpty(token))
                return BadRequest(new { message = "Token is required" });
            var response = _userServices.RevokeRefreshToken(token);
            if (!response)
                return NotFound(new { message = "Token not found" });
            return Ok(new { message = "Token revoked" });
        }

        [HttpGet("all-categories")]
        public IActionResult GetAllCategories()
        {
            var result = _categoryServices.GetAllCategories();
            return Ok(result);
        }

        [HttpGet]
        [Route("/")]
        public IActionResult test()
        {
            return Ok("You did it");
        }

        //[HttpDelete("Logout")]
        //public async Task<IActionResult> Logout()
        //{
        //    var result=await _userServices.LogoutAsync();
        //    // accept token from request body or cookie
        //    var token = Request.Cookies["refreshToken"];
        //    var response = _userServices.RevokeRefreshToken(token);
        //    if (result== "Signed out successfully")
        //    {  
        //        if (string.IsNullOrEmpty(token))
        //            return BadRequest(new { message = "Token is required" }); 
        //        if (!response)
        //            return NotFound(new { message = "Token not found" });
        //        return Ok(result);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
               
            
        //}
        
    }
}
