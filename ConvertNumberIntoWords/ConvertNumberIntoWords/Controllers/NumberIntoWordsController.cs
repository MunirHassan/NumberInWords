using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConvertNumberIntoWords.Services;

namespace ConvertNumberIntoWords.Controllers
{
    public class NumberIntoWordsController : Controller
    {
        [HttpGet]
        [Route("api/numberConversion")]
        public async Task<IActionResult> ConverterNumberIntoWords(string name, decimal number)
        {
            return await Task.FromResult(Ok(new ConversionServices().NumberConversionService(name, number)));
        }
    }
}