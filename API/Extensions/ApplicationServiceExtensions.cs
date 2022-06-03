using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
                                                                IConfiguration config) 
        {
            
                services.AddScoped<ITokenService, TokenService>();
 
                services.AddDbContext<Gielda_testContext>(options => options.UseSqlServer(@"Server=MTSSERWER12A\MSSQL2012SERVER;Database=Gielda_test;Trusted_Connection=True;"));

                return services;
                
        }
    }
}