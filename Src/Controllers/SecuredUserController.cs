using Aduaba.DTO;
using Aduaba.DTO.Account;
using Aduaba.DTO.Product;
using Aduaba.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SecuredUserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        private readonly ICategoryServices _categoryServices;
        public SecuredUserController(IUserServices userServices,ICategoryServices categoryServices)
        {
            _userServices = userServices;
            _categoryServices = categoryServices;
        }
        [HttpGet]
        public IActionResult GetSecuredData()
        {
            
            return Ok("This Secured Data is available only for Authenticated Users.");
        }
        
        [HttpPut("update")]
        public async Task<ActionResult> UpdateAsync([FromBody] UpdateRequest model)
        {

            var result = await _userServices.UpdateAsync(model);
            return Ok(result);
        }
        //[HttpPost("Logout")]
        //public async Task<IActionResult> Logout()
        //{
        //    var result = await _userServices.LogoutAsync();
        //    // accept token from request body or cookie
        //    var token = Request.Cookies["refreshToken"];
        //    var response = _userServices.RevokeRefreshToken(token);
        //    if (result == "Signed out successfully")
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
        [HttpDelete("Delete")]
        public async Task<IActionResult>Delete()
        {
            var result = await _userServices.DeleteAsync();
            return Ok(result);
        }

        [HttpPost("addcategories")]
        [Authorize(Roles ="Administrator")]
        public IActionResult AddCategories([FromBody]AddCategoryRequest model)
        {
            var result = _categoryServices.AddCategory(model);
            return Ok(result);
        }
    }
}
