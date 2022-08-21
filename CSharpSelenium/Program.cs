using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CSharpSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver webDriver = new ChromeDriver("D://Learning//chrome_driver//");

            webDriver.Url = "https://www.amazon.in/";
        }
    }
}
