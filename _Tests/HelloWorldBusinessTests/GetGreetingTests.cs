using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldBusiness;

namespace HelloWorldBusinessTests
{
    [TestClass]
    public class HelloWorldBusinessTests
    {
        [TestMethod]
        public void NotCorrectGreetingTest()
        {
            // Arrange
            string expectedGreetng = "Goodbye";
            IGreeting greeting = new Greeting();

            // Act
            string actualGreeting = greeting.GetGreeting;

            // Assert
            Assert.AreNotEqual(expectedGreetng, actualGreeting);
        }

        [TestMethod]
        public void CorrectlyGetsGreetingTest()
        {
            // Arrange
            string expectedGreetng = "Hello DevOps World with testing!!!";
            IGreeting greeting = new Greeting();

            // Act
            string actualGreeting = greeting.GetGreeting;

            // Assert
            Assert.AreEqual(expectedGreetng, actualGreeting);
        }
    }
}
