using Moq;
using System;
using Xunit;

namespace ConsoleApp1.UnitTests
{
    public class Class1Should
    {
        [Theory]
        [InlineData("Traitement simul�")]
        [InlineData("Traitement simul� 2")]
        [InlineData("Traitement simul� 3")]
        [InlineData("Traitement simul� 4")]
        public void ReturnTextFromOtherClass(string expected)
        {
            // Arrange
            Mock<IPossedeTraitement> mockTraitement = new Mock<IPossedeTraitement>();
            mockTraitement.Setup(t => t.Traitement()).Returns(expected);

            Class1 sut = new Class1(mockTraitement.Object);

            // Act
            var result = sut.Traitement();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
