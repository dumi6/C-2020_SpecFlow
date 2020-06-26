using JuneProject.PageObjects;
using JuneProject.Utility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace JuneProject.StepDefinitions
{
    [Binding]
    public class NewPageSteps
    {
        NewArrivalPage newArrivalPage;
        [Given(@"A customer navigates to New arrivals")]
        public void GivenACustomerNavigatesToNewArrivals()
        {
            newArrivalPage = new NewArrivalPage();
           
        }

        [When(@"A customer clicks on the tab New")]
        public void WhenACustomerClicksOnTheTabNew()
        {
            newArrivalPage.ClickNewArrivalTab();
        }

        [When(@"A customer clicks on blue denim jacket")]
        public void WhenACustomerClicksOnBlueDenimJacket()
        {
            newArrivalPage.ClickClickDenimJeans();
        }
        [Then(@"A customer clicks AddToCart")]
        public void ThenACustomerClicksAddToCart()
        {
            newArrivalPage.ClickAddToCartTab();
        }

        [Then(@"A customer verifies that the jacket has been added to the cart")]
        public void ThenACustomerVerifiesThatTheJacketHasBeenAddedToTheCart()
        {
            newArrivalPage.ClickViewCartTab();
            //newArrivalPage.ValidateNewArrival();
        }

    }


}
