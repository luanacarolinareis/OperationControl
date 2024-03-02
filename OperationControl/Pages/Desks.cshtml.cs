using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace OperationControl.Pages
{
    public class DesksModel : PageModel
    {

        public string[] DeskNames { get; } = { "Desk 1", "Desk 2", "Desk 3", "Desk 4", "Desk 5" };



        public IActionResult OnPost(int deskIndex)
        {
            // Aqui você pode redirecionar para a página específica da desk clicada
            return RedirectToPage($"Desk{deskIndex}");
        }
    }

}


