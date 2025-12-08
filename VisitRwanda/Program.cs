using VisitRwanda.Models;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<VisitRwandaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("VisitRwandaContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
//Tourism route
app.MapControllerRoute(
    name: "tourism",
    pattern: "tourism/{action=Index}/{id?}",
    defaults: new { controller = "Destinations" });

// Culture route
app.MapControllerRoute(
    name: "culture",
    pattern: "culture/{action=Index}/{id?}",
    defaults: new { controller = "Cultures" });

// Investment route
app.MapControllerRoute(
    name: "investment",
    pattern: "investment/{action=Index}/{id?}",
    defaults: new { controller = "Investments" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
