using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cup1.Services;
using cup1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cup1.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        private readonly DbService dbService;
        private readonly JsonResult emptyJson;

        public UsersController(DbService dbService)
        {
            this.dbService = dbService;
            this.emptyJson = new JsonResult(new object());
        }

        // GET /users/<id>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(uint id)
        {
            Console.WriteLine($"GET /users/{id}");

            if (id == 0)
            {
                return new NotFoundResult();
            }
            return new JsonResult(new User { Id = id });
        }

        // POST /users/<id>
        [HttpPost("{id}")]
        public async Task<IActionResult> Post(uint id, [FromBody]User user)
        {
            Console.WriteLine($"POST /users/{id}: {user}");

            if (id == 0)
            {
                return new NotFoundResult();
            }
            return this.emptyJson;
        }

        // POST /users/new
        [HttpPost("new")]
        public async Task<IActionResult> PostNew([FromBody]User user)
        {
            Console.WriteLine($"POST /users/new: {user}");
            return this.emptyJson;
        }
    }
}
