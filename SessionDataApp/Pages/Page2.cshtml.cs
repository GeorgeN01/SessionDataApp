using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

//George Njubi, Exercise: How to work with session state video (Individual) - Optional, Date: 11/29/20


namespace SessionDataApp.Pages
{
    public class Page2Model : PageModel
    {
        public string name;

        public int age;

        public void OnGet()
        {
            if (HttpContext.Session.GetString("Name") != null)
                name = HttpContext.Session.GetString("Name");

            if (HttpContext.Session.GetInt32("Age") != null)
                age = (Int32)HttpContext.Session.GetInt32("Age");
        }
    }
}
