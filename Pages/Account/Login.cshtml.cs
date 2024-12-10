using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NetWebApp_Security.Pages;

public class LoginModel : PageModel
{
    private readonly ILogger<LoginModel> logger;

    [BindProperty]
    public Credential Credential{ get; set; }

    public LoginModel(ILogger<LoginModel> logger)
    {
        this.logger = logger;
    }

    public void OnGet(){

    }

    public void OnPost() { 
        if(!ModelState.IsValid){
            // return Page();
        }
    }
}

public class Credential
{
    [Required]
    public string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [StringLength(10)]
    public string Password { get; set; }
}