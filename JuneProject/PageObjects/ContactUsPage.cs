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
    public class ContactUsPage
    {
        public ContactUsPage()
        {
            PageFactory.InitElements(BasePage._driver, this);
        }
        [FindsBy(How = How.LinkText, Using = "Contact us")]
        IWebElement ClickOnContactUsTab;

        [FindsBy(How = How.XPath, Using = "//input[@id='name']")]
        IWebElement ContactNameTab;

        [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        IWebElement ContactEmailTab;

        [FindsBy(How = How.XPath, Using = "//input[@id='subject']")]
        IWebElement ContactSubjectTab;

        [FindsBy(How = How.XPath, Using = "//textarea[@id='message']")]
        IWebElement ContactMessageTab;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn regular-main-button submit submit btn-warning']")]
        IWebElement ContactSubmitBtn;

        [FindsBy(How = How.XPath, Using = "//div[@id='status-messages']//ul")]
        IWebElement ValidateContactUs;

        public void SubmitClickOnContactUsTab()
        {
            ClickOnContactUsTab.Click();
        }
        public void SubmitContactNameTab(string name)
        {
            ContactNameTab.SendKeys(name);
        }

        public void SubmitContactEmailTab(string email)
        {
            ContactEmailTab.SendKeys(email);
        }
        public void SubmitContactSubjectTab(string subject)
        {
            ContactSubjectTab.SendKeys(subject);
        }
        public void SubmitContactMessageTab(string message)
        {
            ContactMessageTab.SendKeys(message);
                
        }
        public void SubmitContactSubmitBtn()
        {
            ContactSubmitBtn.Click();

        }
        public void ValidateContactUsPage()
        {
            Assert.IsTrue(ValidateContactUs.Displayed);
            Console.WriteLine("Page submittend successfully!");

        } 



    }
}
