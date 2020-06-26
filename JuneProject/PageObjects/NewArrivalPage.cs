using JuneProject.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuneProject.PageObjects
{
   public class NewArrivalPage
    {
        public NewArrivalPage()
        {
            PageFactory.InitElements(BasePage._driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'New!')]")]
        IWebElement NewArrivalTab;

        [FindsBy(How = How.XPath, Using = "//a [contains(text(),'Skinny Western Denim Jacket in Light Blue Wash')]")]
        IWebElement ClickDenimJeans;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn  regular-button regular-main-button add2cart submit']")]
        IWebElement AddToCartTab;

        [FindsBy(How = How.XPath, Using = "//div[@class='item-buttons']//span[contains(text(),'View cart')]")]
        IWebElement ViewCartTab;

        [FindsBy(How = How.LinkText, Using = "Your shopping cart - 1 item")]
        IWebElement ValidateNew;
        public void ClickNewArrivalTab()
        {
            NewArrivalTab.Click();
        }
        public void ClickClickDenimJeans()
        {
            ClickDenimJeans.Click();
        }
        public void ClickAddToCartTab()
        {
            AddToCartTab.Click();
        }
        public void ClickViewCartTab()
        {
            ViewCartTab.Click();
        }
        public void ValidateNewArrival()
        {
            
            //Assert.IsTrue(ValidateNew.Displayed);
           
        }
    }

}
