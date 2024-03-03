using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OperationControl.Models;
using System.Linq;

namespace OperationControl.Pages
{
    public class VerificationModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public VerificationModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public int DeskIndex { get; set; }

        public string AlertMessage { get; set; }

        public IActionResult OnGet(int deskIndex)
        {
            DeskIndex = deskIndex;

            Desk desk = _dbContext.desks.FirstOrDefault(d => d.deskID == deskIndex);

            if (desk == null)
            {
                return NotFound(); 
            }
            else
            {

                if (!desk.kamishibai && desk.checkFinal)
                {
                    AlertMessage = "Alert: Kamishibai not done";
                }
                else if (desk.kamishibai && !desk.checkFinal)
                {
                    AlertMessage = "Alert: Last day's check not done";
                }
                else if (!desk.kamishibai && !desk.checkFinal)
                {
                    AlertMessage = "Alert: Kamishibai and Last day's check not done";
                }
                else
                {
                    AlertMessage = "All procedures done correctly";
                }
            }

            return Page();
        }

        public IActionResult OnPost(int deskIndex)
        {
            DeskIndex = deskIndex;

            Desk desk = _dbContext.desks.FirstOrDefault(d => d.deskID == deskIndex);

            if (desk.kamishibai && desk.checkFinal)
            {
                return RedirectToPage("Control1", new { deskIndex = DeskIndex });
            }
            else if (!desk.kamishibai && desk.checkFinal)
            {
                desk.kamishibai = true;
                _dbContext.SaveChanges();
                return RedirectToPage("Kamishibai", new { deskIndex = DeskIndex });
            }
            else if (!desk.checkFinal && desk.kamishibai)
            {
                desk.checkFinal = true;
                _dbContext.SaveChanges();
                return RedirectToPage("CheckingFinalDay", new { deskIndex = DeskIndex });
            }
            else
            {
                desk.kamishibai = true;
                _dbContext.SaveChanges();
                return RedirectToPage("Kamishibai", new { deskIndex = DeskIndex });
            }
        }
    }
}


