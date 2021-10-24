using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calc
    {
        public Calc(int no1, int no2, int tot)
        {
            this.no1 = no1;
            this.no2 = no2;
            this.tot = tot;
        }

        public Calc()
        {
        }

        [Display(Name ="Nº 1 ")]
        public int no1 { get; set; }
        [Display(Name = "Nº 2 ")]
        public int no2 { get; set; }
        public int tot { get; set; }
    }
}
