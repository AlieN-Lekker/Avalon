using Avalon.Api.Services;
using Avalon.Domain;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;


namespace Avalon.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _service.GetUsers();
        }
    }
}
