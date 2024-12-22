using API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AccountController:ControllerBase
    {
        
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<AppUser> userManager, 
        RoleManager<IdentityRole> roleManager,
        IConfiguration configuration
        ){
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
    }
}
