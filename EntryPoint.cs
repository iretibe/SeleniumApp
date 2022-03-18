using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumApp
{
    internal class EntryPoint
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
