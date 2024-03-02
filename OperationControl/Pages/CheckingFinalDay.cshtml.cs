using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OperationControl.Pages
{
    public class CheckingFinalDayModel : PageModel
    {
    
        [BindProperty]
        public string SeriesNumber { get; set; }

        [BindProperty]
        public bool Checkbox1 { get; set; }

        [BindProperty]
        public bool Checkbox2 { get; set; }

        [BindProperty]
        public bool Checkbox3 { get; set; }

        [BindProperty]
        public bool Checkbox4 { get; set; }

        [BindProperty]
        public bool Checkbox5 { get; set; }

        [BindProperty]
        public bool Checkbox6 { get; set; }

        [BindProperty]
        public bool Checkbox7 { get; set; }

        [BindProperty]
        public bool Checkbox8 { get; set; }


        public void OnGet()
        {
            // Lógica para quando a página é carregada pela primeira vez
        }

        public void OnPost()
        {
            // Aqui você pode acessar os valores inseridos no formulário
            // que foram armazenados nas propriedades correspondentes do modelo
            string numeroDeSerie = SeriesNumber;
            bool okSelecionado = Checkbox1;
            bool ausenteSelecionado = Checkbox2;
            bool danificadoSelecionado = Checkbox3;
            bool foraDeCalibracaoSelecionado = Checkbox4;

            // Faça o que for necessário com esses valores, como salvá-los no banco de dados ou processá-los de outra forma
        }
    

    }
}
