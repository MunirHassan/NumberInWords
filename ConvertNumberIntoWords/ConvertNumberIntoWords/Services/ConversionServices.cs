using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConvertNumberIntoWords.Models;
using NumberToWordConverter;

namespace ConvertNumberIntoWords.Services
{
    public class ConversionServices
    {
        public NameAndNumber NumberConversionService(string name, decimal number)
        {
            var _nameAndNumber = new NameAndNumber
            {
                Name = name,
                NumberInWords = NumberToWordConversion.NumberToCurrencyText(number)
            };

            return _nameAndNumber;
        }
    }
}
