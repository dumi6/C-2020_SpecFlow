using JuneProject.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuneProject.PageObjects
{
    public class SignInSignUpPage
    {
        public SignInSignUpPage()
        {
            PageFactory.InitElements(BasePage._driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'header_bar-sign_in')]//span[contains(text(),'Sign in')]")]
       IWebElement SignInSignUpBtn;

        [FindsBy(How = How.XPath, Using = "//input[@id='login-email']")]
        IWebElement EmailBtn;

        [FindsBy(How = How.Name, Using = "password")]
        IWebElement PasswordBtn;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'submit')]//span[contains(text(),'Sign in')]")]
        IWebElement SubmitBtn;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'My account')]")]
        IWebElement MyAccountBtn;

        public void SubmitSignInSignUpBtn()
        {
            SignInSignUpBtn.Click();
        }
        public void SubmitEmailBtn(string email)
        {
            EmailBtn.SendKeys(email);

        }
        public void SubmitPasswordBtn(string password)
        {
            PasswordBtn.SendKeys(password);
        }
        public void SubmitSubmitBtn()
        {
            SubmitBtn.Click();
        }

        public void ValidateMyAccountBtn()
        {
            MyAccountBtn.Click();
        }
    }
}
