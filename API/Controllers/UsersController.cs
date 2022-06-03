using API.Data;
using API.Models; 
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{   
    public class UsersController : BaseApiController
    {
        private readonly Gielda_testContext _context;
        public UsersController(Gielda_testContext context )
        {
            _context = context;
        }
            [AllowAnonymous]
            [HttpGet]
            public async Task<ActionResult<IEnumerable<API.Models.User>>> GetUsers()
            {
                return await _context.Users.ToListAsync(); 
            }

            [Authorize]
            [HttpGet("{id}")]
             public async Task<ActionResult<API.Models.User>> GetUser(int id)
            {
               return await _context.Users.FindAsync(id); 
            }

    }


}