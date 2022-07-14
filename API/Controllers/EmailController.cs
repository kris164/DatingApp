using Microsoft.AspNetCore.Mvc;
using API.Services;
using API.Controllers;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllerss
{
    public class EmailController : BaseApiController
    {
         private readonly IMailService mailService;
        public EmailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

       [AllowAnonymous]
       [HttpPost("send")]
        public async Task<IActionResult> Send( MailRequest request)
        { 
                await mailService.SendEmailAsync(request);
                return Ok(); 
        }
    }
}