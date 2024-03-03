using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OperationControl.Pages
{
    public class DesksModel : PageModel
    {
        public int DeskAtual { get; private set; }

        public string[] DeskNames { get; } = { "Desk 1", "Desk 2", "Desk 3" };

        public IActionResult OnPost(int deskIndex)
        {
            DeskAtual = deskIndex;

            return RedirectToPage("/Verification", new { deskIndex });
        }
    }
}




