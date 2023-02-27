using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Arrange, Act, Assert
namespace DemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            DisplayMessages messages = new DisplayMessages();
            //Arrange
            string expected = "Good Morning Héctor";
            //Act
            string actual = messages.Greeting("Héctor", 2);
            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            DisplayMessages messages = new DisplayMessages();
            //Arrange
            string expected = "Good Afternoon Héctor";
            //Act
            string actual = messages.Greeting("Héctor", 14);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Héctor", 0, "Good Morning Héctor")]
        [InlineData("Héctor", 1, "Good Morning Héctor")]
        [InlineData("Héctor", 2, "Good Morning Héctor")]
        [InlineData("Héctor", 3, "Good Morning Héctor")]
        [InlineData("Héctor", 4, "Good Morning Héctor")]
        [InlineData("Héctor", 5, "Good Morning Héctor")]
        [InlineData("Héctor", 6, "Good Morning Héctor")]
        [InlineData("Héctor", 7, "Good Morning Héctor")]
        [InlineData("Héctor", 8, "Good Morning Héctor")]
        [InlineData("Héctor", 9, "Good Morning Héctor")]
        [InlineData("Héctor", 10, "Good Morning Héctor")]
        [InlineData("Héctor", 11, "Good Morning Héctor")]
        [InlineData("Héctor", 12, "Good Afternoon Héctor")]
        [InlineData("Héctor", 13, "Good Afternoon Héctor")]
        [InlineData("Héctor", 14, "Good Afternoon Héctor")]
        [InlineData("Héctor", 15, "Good Afternoon Héctor")]
        [InlineData("Héctor", 16, "Good Afternoon Héctor")]
        [InlineData("Héctor", 17, "Good Afternoon Héctor")]
        [InlineData("Héctor", 18, "Good Evening Héctor")]
        [InlineData("Héctor", 19, "Good Evening Héctor")]
        [InlineData("Héctor", 20, "Good Evening Héctor")]
        [InlineData("Héctor", 21, "Good Evening Héctor")]
        [InlineData("Héctor", 22, "Good Evening Héctor")]
        [InlineData("Héctor", 23, "Good Evening Héctor")]

        public void GreetingShouldReturnExpectedValue(string firstName, int hourOfTheDay, string expected)
        {
            DisplayMessages messages = new DisplayMessages();
            //Arrange
            //Act
            string actual = messages.Greeting(firstName, hourOfTheDay);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
