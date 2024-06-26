using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Providers.Entities;
using UserprojectusingBlazor.Server.Interface;
using UserprojectusingBlazor.Shared.Models;

namespace UserprojectusingBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserdetail _IUserdetail;
        public UserController(IUserdetail iUser)
        {
            _IUserdetail = iUser;
        }
        [HttpGet]
        public async Task<List<UserClass>> Get()
        {
            return await Task.FromResult(_IUserdetail.GetUserDetails());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            UserClass user = _IUserdetail.GetUserById(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(UserClass user)
        {
            _IUserdetail.AddUser(user);
        }
        [HttpPut]
        public void Put(UserClass user)
        {
            _IUserdetail.UpdateUserDetails(user);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _IUserdetail.DeleteUser(id);
            return Ok();
        }
    }
}
