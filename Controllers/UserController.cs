using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreJWTAuthentication.Models;
using NetCoreJWTAuthentication.Services;

namespace NetCoreJWTAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserService service;

        public UserController(UserService _service)
        {
            service = _service;
        }
        [HttpGet]
        public ActionResult<List<User>> GetUsers() => service.GetUsers();

        [HttpGet("{id:length(24)}")]
        public ActionResult<User> GetUser(string id)
        {
            var user = service.GetUser(id);
            return Json(user);
        }

        [HttpPost]
        public ActionResult<User> Create(User user){
            service.Create(user);
            return Json(user);
        }
    }
}