using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class ExtensionsTests
    {

        [Fact]
        public void Uri_isSecure_returns_true() 
        {
            //Arrange
            Uri link = new Uri("https://github.com/Restitutor-Orbis/BDSA-Assignment3");

            //Act
            var actual = link.IsSecure();

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void Uri_isSecure_returns_false() 
        {
            //Arrange
            Uri link = new Uri("http://github.com/Restitutor-Orbis/BDSA-Assignment3");

            //Act
            var actual = link.IsSecure();

            //Assert
            Assert.False(actual);
        }


        [Fact]
        public void WordCount_returns_number_of_words_correct() 
        {
            //Arrange
            var str = "Hej med dig";

            //Act
            var actual = str.WordCount();
            var expected = 3;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WordCount_returns_number_of_words_exclude_numbers_correct() 
        {
            //Arrange
            var str = " 1 Hej 2 med 3 dig 4";

            //Act
            var actual = str.WordCount();
            var expected = 3;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WordCount_returns_number_of_words_incorrect() 
        {
            //Arrange
            var str = "Hej med dig 32 hej hej hej__";

            //Act
            var actual = str.WordCount();
            var expected = 7;

            //Assert
            Assert.NotEqual(expected, actual);
        }



    }
}
