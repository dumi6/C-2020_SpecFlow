using JuneProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace JuneProject.StepDefinitions
{
    [Binding]
    public class ContactUsPageSteps
    {
        public SignInSignUpPage SSP;
        public ContactUsPage CP;
        [Given(@"A customer needs help")]
        public void GivenACustomerNeedsHelp()
        {
            CP = new ContactUsPage();
            SSP = new SignInSignUpPage();

            

        }
        [When(@"A customer clicks on ContactTab")]
        public void GivenACustomerClicksOnContactTab()
        {
            CP.SubmitClickOnContactUsTab();
        }


        [When(@"Customer enters name '(.*)'")]
        public void WhenCustomerEntersName(string name)
        {
            CP.SubmitContactNameTab(name);
        }

        [When(@"A customer enters his email '(.*)'")]
        public void WhenACustomerEntersHisEmail(string email)
        {
            CP.SubmitContactEmailTab(email);
        }

        [When(@"A customer enters subject '(.*)'")]
        public void WhenACustomerEntersSubject(string subject)
        {
            CP.SubmitContactSubjectTab(subject);
        }

        [When(@"A customer enters the message '(.*)'")]
        public void WhenACustomerEntersTheMessage(string message)
        {
            CP.SubmitContactMessageTab(message);
        }

        [Then(@"A customer clicks on send button to submit the message")]
        public void ThenACustomerClicksOnSendButtonToSubmitTheMessage()
        {
            CP.SubmitContactSubmitBtn();
        }
        [Then(@"A customer Validates ContactUs page")]
        public void ThenACustomerValidatesContactUsPage()
        {
            CP.ValidateContactUsPage();
        }



    }
}
