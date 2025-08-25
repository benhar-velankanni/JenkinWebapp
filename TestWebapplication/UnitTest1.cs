using Webapplication.Pages;

namespace TestWebapplication
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void OnGet_SetsMessageCorrectly()
        {
            // Arrange
            var model = new IndexModel();

            // Act
            model.OnGet();

            // Assert
            Assert.AreEqual("Welcome to ASP.NET Core!", model.Message);
        }

    }
}