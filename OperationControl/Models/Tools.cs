﻿using System.ComponentModel.DataAnnotations;

namespace OperationControl.Models
{
    public class Tools
    {
        [Key] public int numero { get; set; }
        public int deskID { get; set; }
        public int numeroSerie { get; set; }

        public string nome { get; set; }

        public string estado { get; set; }
    }
}
