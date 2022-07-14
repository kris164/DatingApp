using System.Text;
using API.Data;
using API.Extensions;
using API.Interfaces;
using API.Middleware;
using API.Services;
using BIRService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
 
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ITokenService, TokenService>(); 
           

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));

 

builder.Services.AddApplicationServices(builder.Configuration);
 
builder.Services.AddControllers();
builder.Services.AddCors();

builder.Services.AddIdentifyServices(builder.Configuration);

IServiceCollection serviceCollection = builder.Services.AddSingleton<RegonService>();
var birKey = builder.Configuration.GetSection("BIRService").Value;
builder.Services.AddTransient<IBIRSearchService>(x => new BIRSearchService(birKey));

 
       

builder.Services.AddOptions<MailSettings>()
            .Bind(builder.Configuration.GetSection("MailSettings"))
            .ValidateDataAnnotations() .Validate(config =>
        {
            if (config.ToString() != "")
            {
                 
            }

            return true;
        }, "Key3 must be > than Key2.");   // Failure message.


builder.Services.AddTransient<IMailService,  MailService>();

 // var emailConfig = builder.Configuration 
  //      .GetSection("MailSettings")
 //       .Get<MailService>();

  //  builder.Services.AddSingleton(emailConfig);
    builder.Services.AddScoped<IMailService, MailService>();
//IServiceCollection serviceEmailCollection = builder.Services.AddSingleton<MailService>();

 // serviceEmailCollection.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
 //serviceEmailCollection.AddTransient<IMailService, MailService>();
   

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
 

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
 

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));


app.UseAuthentication();
app.UseAuthorization();

//app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
