using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PepperAdvantage_Assignment.DTOs;
using PepperAdvantage_Assignment.Model;
using PepperAdvantage_Assignment.Service;
using System.Diagnostics;

namespace PepperAdvantage_Assignment.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _userService;
        private UserContext _userContext;

        public UserController(UserContext userContext)
        {
            _userService = new UserService();
            _userContext = userContext;
        }

        [HttpGet, Route("getuser")]
        public async Task<IActionResult> GetContacts()
        {
            List<User> list;
            string sql = "EXEC GetUserRole";
            list = await _userContext.Users.FromSqlRaw<User>(sql).ToListAsync();
            return  Ok(list);
        }
         
    }
}
