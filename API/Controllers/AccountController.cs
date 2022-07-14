using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Models ;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly Gielda_testContext _context ;
        private readonly ITokenService _tokenService;
        public AccountController( Gielda_testContext context, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(User registerDto){


            if  (await  UserExists(registerDto.UserName)) 
                return BadRequest("Login już istenieje");
 
                using var hmac = new HMACSHA512();
                var user = new API.Models.User{ 
                     UserName = registerDto?.UserName.ToLower() ,
                    PasswordHash= hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                    PasswordSalt=hmac.Key,
                     nip=registerDto.nip,
                     kodPocztowy=registerDto.kodPocztowy,
                     regon=registerDto.regon,
                     statusNip=registerDto.statusNip,
                     nazwa=registerDto.nazwa,
                     wojewodztwo=registerDto.wojewodztwo,
                     powiat=registerDto.powiat,
                     gmina=registerDto.gmina,
                     miejscowosc=registerDto.miejscowosc,
                     ulica=registerDto.ulica,
                     nrNieruchomosci=registerDto.nrNieruchomosci,
                     nrLokalu=registerDto.nrLokalu,
                     miejscowoscPoczty=registerDto.miejscowoscPoczty,
                     ciagnikSiodlowy=registerDto.ciagnikSiodlowy,
                     ciagnikTrojosiowy=registerDto.ciagnikTrojosiowy,
                     ciagnikTypuMega=registerDto.ciagnikTypuMega,
                     ciagnikTypuMegaReagul=registerDto.ciagnikTypuMegaReagul,
                     jumbo=registerDto.jumbo,
                     naczepaOplanegkowana=registerDto.naczepaOplanegkowana,
                     megaNaczepaOplanegkowana=registerDto.megaNaczepaOplanegkowana,
                     mobile=registerDto.mobile,
                     email=registerDto.email,

                    };

                    _context.Add(user);
                   await _context.SaveChangesAsync();

                   return new UserDto{
                       Username=user.UserName,
                       Token =_tokenService.CreateToken(user)
                   };
        }
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login (LoginDto loginDto)
        {
                var user = await _context.Users
                .SingleOrDefaultAsync(x=>x.UserName == loginDto.Username);
                if (user == null)
                return Unauthorized("Invalid username");

                using var hmac = new HMACSHA512(user.PasswordSalt);

                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password)); 

                for(int i = 0; i< computedHash.Length;i++ )
                {
                    if(computedHash[i] != user.PasswordHash[i]) 
                    return Unauthorized("Invalid password") ;
                }

                   return new UserDto{
                       Username=user.UserName,
                       Token =_tokenService.CreateToken(user)
                   };
        }

        private async Task<bool> UserExists(string username){
            return await _context.Users.AnyAsync(z => z.UserName == username.ToLower());
        }


         private async Task<bool> NipExists(string nip){
            return await _context.Users.AnyAsync(z => z.nip == nip);
        }
    }
}