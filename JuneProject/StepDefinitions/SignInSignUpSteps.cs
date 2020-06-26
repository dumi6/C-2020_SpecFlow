using JuneProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace JuneProject.StepDefinitions
{
    [Binding]
    public class SignInSignUpSteps
    {
        SignInSignUpPage SSP;

        [Given(@"Customer has opened my demoStore")]
        public void GivenCustomerHasOpenedMyDemoStore()
        {
            SSP = new SignInSignUpPage();
        }

        [When(@"Customer clicks SignIn SignUp")]
        public void WhenCustomerClicksSignInSignUp()
        {
            SSP.SubmitSignInSignUpBtn();
        }

        [When(@"Customer enters email '(.*)'")]
        public void WhenCustomerEntersEmail(string email)
        {
            SSP.SubmitEmailBtn(email);
        }

        [When(@"Customer enters password '(.*)'")]
        public void WhenCustomerEntersPassword(string password)
        {
            SSP.SubmitPasswordBtn(password);
        }

        [When(@"Customer clicks Sign button")]
        public void WhenCustomerClicksSignButton()
        {
            SSP.SubmitSubmitBtn();
        }

        [Then(@"the user logged in successfully")]
        public void ThenTheUserLoggedInSuccessfully()
        {
            SSP.ValidateMyAccountBtn();
            
        }



    }
}
