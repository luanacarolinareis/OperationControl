using System.ComponentModel.DataAnnotations;

namespace OperationControl.Models
{
    public class Tools
    {
        [Key] public int Nr { get; set; }
        public int Quantity { get; set; }
        public string? Name { get; set; }
        public int SeriesNr { get; set; }
        public int DeskId { get; set; }
    }
}