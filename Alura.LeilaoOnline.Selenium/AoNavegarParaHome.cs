using Alura.LeilaoOnline.Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace Alura.LeilaoOnline.Selenium
{
    public class AoNavegarParaHome
    {
        [Fact]
        public void DadoChromeAbertoDeveMostrarLeiloesNoTitulo()
        {
            // arrange
            IWebDriver driver = new ChromeDriver(TestHelper.PastaDoExecutavel);

            // act
            driver.Navigate().GoToUrl("http://localhost:51128");

            // assert
            Assert.Contains("Leilões", driver.Title);
        }

        [Fact]
        public void DadoChromeAbertoDeveMostrarProximosLeiloesNaPagina()
        {
            // arrange
            IWebDriver driver = new ChromeDriver(TestHelper.PastaDoExecutavel);

            // act
            driver.Navigate().GoToUrl("http://localhost:51128");

            // assert
            Assert.Contains("Próximos Leilões", driver.PageSource);
        }
    }
}