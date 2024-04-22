using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Text;
using System.Threading;

namespace WebScraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://Google.com/");
            var element = driver.FindElement(By.XPath("//*[@id=\"APjFqb\"]"));
            element.SendKeys("Webshop");
            element.Submit();
            var titles = driver.FindElements(By.XPath("//h3"));

            foreach (var title in titles)
            {
                //Output
                Console.WriteLine(title.Text);



            }

        }
    }
}

