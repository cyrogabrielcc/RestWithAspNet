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
        public IActionResult GetSoma(string f1, string f2)
        {
            if (isNumeric(f1) && isNumeric(f2))
            {
                var sum = convertToDouble(f1) + convertToDouble(f2);
                return Ok(sum.ToString());
            }
            return BadRequest("input inválido");
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult GetSubtracao(string f1, string f2)
        {
            if (isNumeric(f1) && isNumeric(f2))
            {
                var sum = convertToDouble(f1) - convertToDouble(f2);
                return Ok(sum.ToString());
            }
            return BadRequest("input inválido");
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult GetDivisao(string f1, string f2)
        {
            if (isNumeric(f1) && isNumeric(f2))
            {
                var sum = convertToDouble(f1) - convertToDouble(f2);
                return Ok(sum.ToString());
            }
            return BadRequest("input inválido");
        }
        
        public bool isNumeric(string num)
        {
            return double.TryParse(num, out double n);
        }

        public double convertToDouble(string n)
        {
            return Convert.ToDouble(n);
        }
    }
}