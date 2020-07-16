using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JWT_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        public UserProfileController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        
        [HttpGet("GetName")]
        public string GetName()
        {
            return "this withOut Auth";
        }
        [Authorize]
        [HttpGet("GetNameAuth")]
        public string GetNameAuth()
        {
            return "this withOut Auth";
        }
    }
}