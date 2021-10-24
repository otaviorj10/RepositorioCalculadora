using Calculadora.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Calcular()
        {
            return View(new Calc());
        }

        [HttpPost]
        public   IActionResult Calcular(Calc calc , string c)
        {
            var div = 0;
            if (c == "calc")
            {
                calc.tot = calc.no1 + calc.no2;
            } else if(c=="dim")
            {
                calc.tot = calc.no1 - calc.no2;
            }
            else if(c=="divv")
            {
                
                div = calc.no1 / calc.no2;

            }
            else if(c == "mult")
            {
                calc.tot = (calc.no1 * calc.no2);
                
            } else
            {
                return View(calc);
            }
            return   View(calc);
        }
    }
}
