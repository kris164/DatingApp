using API.Data;
using API.DTOs;
using API.Models; 
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class CompanyController: BaseApiController
    {
        
        private readonly Gielda_testContext _context ;

        public CompanyController(Gielda_testContext context)
        {
           _context=context;
        }
 
       
            [AllowAnonymous]
            [HttpPost("company")] 
             public async Task<ActionResult<API.Models.User>> GetCompany(User user)
            {
               return await _context.Users.Where(z=>z.UserName==user.UserName)
               .Select(z=> new User{
                    ciagnikSiodlowy =z.ciagnikSiodlowy,
                    ciagnikTrojosiowy =z.ciagnikTrojosiowy,
                    ciagnikTypuMega =z.ciagnikTypuMega,
                    ciagnikTypuMegaReagul=z.ciagnikTypuMegaReagul,
                     jumbo  =z.jumbo,
                     naczepaOplanegkowana=z.naczepaOplanegkowana,
                     megaNaczepaOplanegkowana=z.naczepaOplanegkowana

               })
               .FirstAsync(); 
            } 


            [AllowAnonymous]
            [HttpGet("{username}")]
             public async Task<ActionResult<API.Models.User>> GetCompany(string username)
            {
               return await _context.Users.Where(z=>z.UserName == username)
               .Select(z=> new User{
                    ciagnikSiodlowy =z.ciagnikSiodlowy,
                    ciagnikTrojosiowy =z.ciagnikTrojosiowy,
                    ciagnikTypuMega =z.ciagnikTypuMega,
                    ciagnikTypuMegaReagul=z.ciagnikTypuMegaReagul,
                     jumbo  =z.jumbo,
                     naczepaOplanegkowana=z.naczepaOplanegkowana,
                     megaNaczepaOplanegkowana=z.naczepaOplanegkowana

               })
               .FirstAsync(); 
            } 
         
    }
 
}