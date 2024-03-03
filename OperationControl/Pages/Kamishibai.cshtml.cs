using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OperationControl.Models;

namespace OperationControl.Pages
{
    public class KamishibaiModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public KamishibaiModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public int DeskIndex { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost(int deskIndex)
        {
            DeskIndex = deskIndex;

            Desk desk = _dbContext.desks.FirstOrDefault(d => d.deskID == deskIndex);


            if (desk.checkFinal)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("CheckingFinalDay", new { deskIndex = DeskIndex });
            }
        }
    }
}
