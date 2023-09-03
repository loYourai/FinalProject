
using Models;
using FinalProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using FluentValidation;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore.Storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
ConfigureServices(builder.Services, builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();



static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    services.AddDbContext<CalendarDbContext>(options =>
    {
        //options.UseInMemoryDatabase("PersonDbContext");
        options.UseSqlServer("Server = DESKTOP-08872OF; Database = MeetingsDB;Integrated Security=true; TrustServerCertificate=True;");
    });

  //  services.AddScoped<IValidator<CreateMeetingModel>>();
   // services.AddScoped<IValidator<EditMeetingModel>, EditMeetingModelValidator>();
}
