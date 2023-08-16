using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _01_RestWithASPNET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string f1, string f2)
        {
            if (isNumeric(f1) && isNumeric(f2))
            {
                var sum = convertToDecimal(f1) + convertToDecimal(f2);
                return Ok(sum.ToString());
            }
            return BadRequest("input inválido");
        }

        public bool isNumeric(string num)
        {
            return double.TryParse(num, out double n);
        }

        public double convertToDecimal(string n)
        {
            return Convert.ToDouble(n);
        }
    }
}