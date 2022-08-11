using Business.Abstract;
using DTO.User;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Get ()
        {
            var data = _userService.GetAllUsers();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post(CreateUserRequest user)
        {
            
            var response = _userService.Insert(user);
            return Ok(response);
        }
        [HttpPut]
        public IActionResult Put (UpdateUserRequest user)
        {
            var response = _userService.Update(user);
            return Ok(response);

        }
        [HttpDelete]
        public IActionResult Delete (UserInfo user)
        {
            var response = _userService.Delete(user);
            return Ok(response);
        }
    }
}
