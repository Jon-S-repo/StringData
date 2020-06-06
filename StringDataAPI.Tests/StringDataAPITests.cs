using System;
using Xunit;
using StringDataAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace StringDataAPI.Tests
{
    public class StringDataAPITests
    {
        [Fact]
        public void StringDataAPI_AlphabetInput()
        {
            //Arrange
            var controller = new StringDataController();

            //Act
            var result = controller.Get("aba");

            //Assert
            Assert.IsType<OkObjectResult>(result);

            var okResult = result as OkObjectResult;
            Assert.Equal(200, okResult.StatusCode);

            Assert.IsType<StringData>(okResult.Value);
            StringData resultObject = okResult.Value as StringData;
            Assert.True(resultObject.IsPalindrome);
            Assert.Equal(resultObject.SortedCharacterCount.Length,2);
            Assert.Equal('a', resultObject.SortedCharacterCount[0].character);
            Assert.Equal(2, resultObject.SortedCharacterCount[0].count);
            Assert.Equal('b', resultObject.SortedCharacterCount[1].character);
            Assert.Equal(1, resultObject.SortedCharacterCount[1].count);
        }

        [Fact]
        public void StringDataAPI_NonAlphabetInput()
        {
            //Arrange
            var controller = new StringDataController();

            //Act
            var result = controller.Get("123");

            //Assert
            Assert.IsType<ObjectResult>(result);
            var objectResult = result as ObjectResult;
            Assert.Equal(500, objectResult.StatusCode);
        }
    }
}
