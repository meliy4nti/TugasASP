using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using AbsenOnline.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbsenOnline.Pages
{
     public class LoginModel : PageModel
    {
        private readonly IConfiguration configuration;

    public LoginModel(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
[BindProperty]

public string UserEmail { get; set; }
[BindProperty, DataType(DataType.Password)]

public string Password { get; set; }
public string Message { get; set; }
    


public async Task<IActionResult> onPost()
{
    var user = configuration.GetSection("User").Get<User>();
    if (UserEmail == user.Email)
    {
        var passwordHasher = new PasswordHasher<string>();
        if (passwordHasher.VerifyHashedPassword(null, user.Password, Password)
        == PasswordVerificationResult.Success)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, UserEmail)
            };
            var claimsIdentity = new ClaimsIdentity(claims, 
            CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, 
                new ClaimsPrincipal(claimsIdentity));
                return RedirectToPage("/Index");
        }
    }
       Message = "Invalid attempt";
        return Page();
//}

       // private IActionResult RedirectToPageResult(string v)
       // {
        //    throw new NotImplementedException();
       // }
    }//end post
}
}
