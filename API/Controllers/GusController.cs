using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using API.GusModel;
using BIRService;
using BIRService.Models;
using API.Controllers.Tools;

namespace API.Controllers
{
    public class GusController: BaseApiController
    {
        
         IBIRSearchService _birSearchService;

        public GusController(IBIRSearchService birSearchService)
        {
            _birSearchService = birSearchService;
        }

            [AllowAnonymous]
            [HttpGet("{nip}")]
            public async Task<ActionResult<DanePodmiotu>> GetCompany(string nip)
            {
                 return await _birSearchService.GetCompanyDataByNipIdAsync(Nip.CleanNip(nip));
            } 
    }
}