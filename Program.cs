using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using E_Commerce.Data;
using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using static System.Console;
using System.Net.Http.Headers;
using E_Commerce.Controllers;
using E_Commerce.Data.Services;
using Stripe.Checkout;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

if(builder.Environment.IsDevelopment())
{
builder.Services.AddDbContext<JumaContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
    builder.Services.AddScoped<IImageService, ImageService>();
}
else
{
builder.Services.AddDbContext<JumaContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ProductionJuma")));

    //Services
    builder.Services.AddScoped<IImageService, ImageService>();
}

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDataProtection();
builder.Services.AddRazorPages();
builder.Services.AddMvc().AddNewtonsoftJson();
      
string databasePath = Path.Combine("..", "Juma.db");
builder.Services.AddDbContext<JumaContext>(options => 
options.UseSqlite($"Data Source={databasePath}"));
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
}
StripeConfiguration.ApiKey = "sk_test_26PHem9AhJZvU623DfE1x4sd";
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapRazorPages();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints => endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
));

app.Run();
