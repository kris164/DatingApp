using API.Data;
using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController: BaseApiController
    {
        private readonly Gielda_testContext _context;
        public BuggyController(  Gielda_testContext  context)
        {
            _context = context;

        }

        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSercet()
        {
            return "secret text";
        }


        [HttpGet("not-found")]
        public ActionResult<API.Models.User> GetNotFound()
        {
           var thing = _context.Users.Find(-1);
           if (thing == null) return NotFound();
           return Ok(thing);
        }

        [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {
            var thing = _context.Users.Find(-1);
           
           var thingToReturn = thing.ToString();

           return thingToReturn;
        }
        
        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return  BadRequest("This was not a good request");
        } 

    }
}