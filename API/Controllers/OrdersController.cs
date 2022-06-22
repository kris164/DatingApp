using API.Data;
using API.Models; 
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class OrdersController: BaseApiController
    {
        private readonly Gielda_testContext _context;
        public OrdersController(Gielda_testContext context )
        {
            _context = context;
        }
            [AllowAnonymous]
            [HttpGet]
            public async Task<ActionResult<IEnumerable<API.Models.Zlecenium>>> GetOrders()
            {
                return await _context.Zlecenia.Where(s=>s.Status == "FO").ToListAsync(); 
            } 
 
    }


}