using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HCOutdoor.Pages
{
    public class PakkerModel : PageModel
    {
        public void OnGet()
        {
            HttpContext.Session.SetString("page", "4");
        }
    }
}
