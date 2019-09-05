using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Uni_Dash.Data;
using Uni_Dash.Models;
using System.Threading.Tasks;

namespace Uni_Dash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        //return a list of employees from our database entity employees
        public IActionResult GetLogins()
        {
            return Ok(_db.Logins.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddLogin([FromBody] Login objLogin)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult("Error While Creating New Login");
            }

            // this Logins is the table name in db
            _db.Logins.Add(objLogin);
            // saves all the changes to the database
            await _db.SaveChangesAsync();

            return new JsonResult("Login Created Successfully");
        }

        [HttpPut("{user}")]
        public async Task<IActionResult> UpdateLogin([FromRoute] string user, [FromBody] Login objLogin)
        {
            if (objLogin == null || user != objLogin.user)
            {
                return new JsonResult("Employee Was Not Found");
            }
            else
            {
                _db.Logins.Update(objLogin);
                await _db.SaveChangesAsync();
                return new JsonResult("Login Was Updated Successfully");
            }
        }

        [HttpDelete("{user}")]
        public async Task<IActionResult> DeleteLogin([FromRoute] string user)
        {
            var findLogin = await _db.Logins.FindAsync(user);
            if (findLogin == null)
            {
                return NotFound();
            }
            else
            {
                _db.Logins.Remove(findLogin);
                await _db.SaveChangesAsync();
                return new JsonResult("Login Was Deleted");
            }
        }
    }
}
