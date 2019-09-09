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
    public class LoginHashController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public LoginHashController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        //return a list of employees from our database entity employees
        public IActionResult GetLoginHashs()
        {
            return Ok(_db.LoginHashs.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddLogin([FromBody] LoginHash objLoginHash)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult("Error While Creating New LoginHash");
            }

            // this LoginHashs is the table name in db
            _db.LoginHashs.Add(objLoginHash);
            // saves all the changes to the database
            await _db.SaveChangesAsync();

            return new JsonResult("LoginHash Created Successfully");
        }
    }
}
