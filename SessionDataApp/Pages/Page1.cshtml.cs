using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

//George Njubi, Exercise: How to work with session state video (Individual) - Optional, Date: 11/29/20

namespace SessionDataApp.Pages
{
    
    public class Page1Model : PageModel
    {
        string name;
        int age;
        public void OnGet()
        {
        }
        public void OnPost()
        {
            name = Request.Form["Name"];
            age = Convert.ToInt32(Request.Form["Age"]);

            HttpContext.Session.SetString("Name", name);
            HttpContext.Session.SetInt32("Age", age);
        }
    }
}
