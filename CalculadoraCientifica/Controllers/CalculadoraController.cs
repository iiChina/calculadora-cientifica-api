using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraCientifica.Controllers;

[ApiController]
[EnableCors("CorsPolicy")]
[Route("calculadora/")]
public class CalculadoraController : ControllerBase
{
    [HttpGet("recursiveFactorial")]
    public IActionResult CalculateRecursiveFactorial(int value)
    {
        var result = RecursiveFactorial(value);
        return Ok(result);
    }

    [HttpGet("nthTenPower")]
    public IActionResult NthTenPower(double value)
    {
        var result = Math.Pow(10, value);
        return Ok(result);
    }

    [HttpGet("sqrt")]
    public IActionResult Sqrt(double value)
    {
        var result = Math.Sqrt(value);
        return Ok(result);
    }

    [HttpGet("square")]
    public IActionResult Square(double value)
    {
        var result = Math.Pow(value, 2);
        return Ok(result);
    }

    [HttpGet("cube")]
    public IActionResult Cube(double value)
    {
        var result = Math.Pow(value, 3);
        return Ok(result);
    }

    [HttpGet("inverseNumber")]
    public IActionResult InverseNumber(double value)
    {
        var result = value * -1;
        return Ok(result);
    }
    
    [HttpGet("sin")]
    public IActionResult Sin(double value)
    {
        var result = Math.Sin(value);
        return Ok(result);
    }

    [HttpGet("cos")]
    public IActionResult Cos(double value)
    {
        var result = Math.Cos(value);
        return Ok(result);
    }

    [HttpGet("tan")]
    public IActionResult Tan(double value)
    {
        var result = Math.Tan(value);
        return Ok(result);
    }

    [HttpGet("log10")]
    public IActionResult Log10(double value)
    {
        var result = Math.Log10(value);
        return Ok(result);
    }

    [HttpGet("log")]
    public IActionResult Log(double value)
    {
        var result = Math.Log(value);
        return Ok(result);
    }

    private decimal RecursiveFactorial(decimal value)
    {
        if (value < 1)
            return 1;

        return value * RecursiveFactorial(value);
    }
}
