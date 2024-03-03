using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace OperationControl.Pages
{
    public class Control1Model : PageModel
    {
        [BindProperty]
        public int ToolCount { get; set; }

        public IActionResult OnPost()
        {
            if (ToolCount > 0)
            {
                return RedirectToPage("/Control1_1", new { toolCount = ToolCount });
            }
            return Page();
        }
    }
}