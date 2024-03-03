using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OperationControl.Pages
{
    public class Control1_1Model : PageModel
    {
        public int ToolCount { get; private set; }

        public void OnGet(int toolCount)
        {
            ToolCount = toolCount;
        }
    }
}