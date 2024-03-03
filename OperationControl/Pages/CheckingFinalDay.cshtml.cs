using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OperationControl.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperationControl.Pages
{
    public class CheckingFinalDayModel : PageModel
    {
        private readonly AppDbContext _context;

        public CheckingFinalDayModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<ToolCheckboxViewModel> Tools { get; set; }

        public class ToolCheckboxViewModel
        {
            public int ToolId { get; set; }
            public string ToolName { get; set; }
            public string Estado { get; set; }
        }

        public async Task OnGetAsync(int deskIndex)
        {
            Tools = await _context.ferramentas
                .Where(tool => tool.deskID == deskIndex)
                .Select(tool => new ToolCheckboxViewModel
                {
                    ToolId = tool.numero,
                    ToolName = tool.nome,
                    Estado = tool.estado
                })
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync(int deskIndex)
        {
            foreach (var tool in Tools)
            {
                var toolToUpdate = await _context.ferramentas.FirstOrDefaultAsync(t => t.numero == tool.ToolId && t.deskID == deskIndex);
                if (toolToUpdate != null)
                {
                    toolToUpdate.estado = tool.Estado;
                }
            }

            await _context.SaveChangesAsync();

            // Redirecionar para a página 
            return RedirectToPage("Verification", new { deskIndex });
        }
    }
}


