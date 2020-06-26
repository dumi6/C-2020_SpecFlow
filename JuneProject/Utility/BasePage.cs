using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace JuneProject.Utility
{
    [Binding]
    public class BasePage
    {

        public static IWebDriver _driver;
        [BeforeScenario]
        public void BeforeScenario()
        {
           _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl("https://demostore.x-cart.com/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            //_driver.Quit();
        }
    }
}
