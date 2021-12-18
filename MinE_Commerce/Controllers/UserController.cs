using BusinessLayer.Abstract;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinE_Commerce.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userManager)
        {
            _userService = userManager;
        }

        [HttpPost]
        public User Insert([FromBody] User user)
        {
            _userService.TAdd(user);
            return user;
        }
        [HttpGet]
        public List<User> GetUser()
        {
            return _userService.GetListAll();
        }
    }
}
