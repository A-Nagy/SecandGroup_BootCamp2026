using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecandGroup_1.Data;
using SecandGroup_1.Models;
using SecandGroup_1.Models.ViewModel;
using SecandGroup_1.Security;
using System.Data;
using System.Security;
using System.Security.Claims;

namespace SecandGroup_1.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(string? returnUrl=null)
        {
            if(User.Identity?.IsAuthenticated == true)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.ReturnUrl = returnUrl;
            return View();

        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model, string? returnUrl = null)
        {
            if (!ModelState.IsValid)
            { 
                ViewBag.ReturnUrl = returnUrl;
                return View(model);
            }
            User? user = _context.Users.Include(u => u.Roles)
                                       .ThenInclude(r => r.Permissions)
                                       .FirstOrDefault(u => u.UserName == model.UserName);
            if (user == null) 
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
                ViewBag.ReturnUrl = returnUrl;
                return View(model);
            }
            if(model.Password != user.Password)
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
                ViewBag.ReturnUrl = returnUrl;
                return View(model);
            }
            // Authentication successful, create claims and sign in the user
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                new Claim("Username" , user.UserName),
            };
            // Add role claims
                foreach (Role role in user.Roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.Name));
                   
                }
            // Add permission claims
            List<string>  permissions = 
                user.Roles.SelectMany(r => r.Permissions).Select(p => p.Name).Distinct().ToList();
             
            foreach (string permission in permissions)
                {
                    claims.Add(new Claim(PermissionsNames.ClaimType, permission));
                }
            //create claims identity and sign in the user
            ClaimsIdentity identity = new ClaimsIdentity(
                                                        claims,
                                                        CookieAuthenticationDefaults.AuthenticationScheme,
                                                        ClaimTypes.Name,
                                                        ClaimTypes.Role);

            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            //Cookie authentication properties
            AuthenticationProperties properties = new AuthenticationProperties
            {
                IsPersistent = model.RememberMe,
                ExpiresUtc = DateTime.UtcNow.AddMinutes(30)
            };
            //login the user  
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                                    principal,
                                    properties);

                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }

                return RedirectToAction("index", "Dashboard");

        }
     
        public IActionResult AccessDenied()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login"); 
        }
        [Authorize]
        [HttpGet]
        public IActionResult MyAccess() 
        {
            return View(); 
        }
    }
}
