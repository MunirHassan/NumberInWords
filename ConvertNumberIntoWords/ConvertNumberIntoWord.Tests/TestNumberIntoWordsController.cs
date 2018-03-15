using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConvertNumberIntoWords.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using ConvertNumberIntoWords.Models;

namespace ConvertNumberIntoWord.Tests
{
    public class TestNumberIntoWordsController
    {
        [Fact]
        public async Task ConverterNumberIntoWordsTest()
        {
            // Arrange
            var controller = new NumberIntoWordsController();

            // Act
            IActionResult actionResult = await controller.ConverterNumberIntoWords("John Smith", 123.45M);

            // Assert
            Assert.NotNull(actionResult);

            OkObjectResult result = actionResult as OkObjectResult;

            Assert.NotNull(result);

            var _nameAndNumber = result.Value as NameAndNumber;

            Assert.Equal("John Smith", _nameAndNumber.Name);
            Assert.Equal("ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS", _nameAndNumber.NumberInWords);
        }
    }
}
