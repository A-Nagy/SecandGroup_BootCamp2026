using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using SecandGroup_1.Data;
using SecandGroup_1.Security;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Dependency Injection (DI) is a design pattern that allows the creation of dependent objects
//outside of a class and provides those objects to a class in different ways.
// making the code more modular, testable, and maintainable.

// Add the ApplicationDbContext to the service container and
// configure it to use SQL Server with the connection string from appsettings.json
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options=>
    {
        options.LoginPath         = "/Account/Login";
        options.AccessDeniedPath  = "/Account/AccessDenied";
        options.ExpireTimeSpan    =  TimeSpan.FromMinutes(30);
        options.SlidingExpiration =  true;
        options.Cookie.HttpOnly   =  true;
        options.Cookie.Name       =  "CompanyMengment.Auth";
    });

builder.Services.AddAuthorization(options =>
{   // Addpolicies for All permissions
    foreach (string  permission in PermissionsNames.All)
    {
        options.AddPolicy(permission, policy =>
        {
            policy.RequireClaim(PermissionsNames.ClaimType, permission);
        });
    }


});

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
