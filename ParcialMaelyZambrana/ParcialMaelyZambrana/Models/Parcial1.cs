using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialMaelyZambrana.Models
{
    public enum CategoryTypeAlpha3Code
    {
        BOL = 10,
        ARG = 20,
        BRZ = 30,
        COL = 40,
        CHL = 50,
        USA = 60,
    }

    public enum CategoryTypeRegion
    {
        NorteAmerica = 10,
        CentroAmerica = 20,
        SudAmerica = 30
    }
    public class Parcial1
    {
        [Required(ErrorMessage = "You must enter this field {0}")]
        public CategoryTypeAlpha3Code Alpha3Code { get; set; }

        [Required(ErrorMessage = "You must enter this field {0}")]
        public CategoryTypeRegion Region { get; set; }

        [Key]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must enter this field {0}")]
        public int Area { get; set; }

        [Required(ErrorMessage = "You must enter this field {0}")]
        public int CallingCode { get; set; }

        [Required(ErrorMessage = "You must enter this field {0}")]
        public string Languages { get; set; }

        [Required(ErrorMessage = "You must enter this field {0}")]
        public string Flag { get; set; }
    }
}