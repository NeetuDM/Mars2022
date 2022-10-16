using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class AvailabilityStepDefinitions: CommonDriver
    {
        [Given(@"I logged in to the Mars website")]
        public void GivenILoggedInToTheMarsWebsite()
        {
            //Open the Chrome Browser
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I navigate to Profile page")]
        public void WhenINavigateToProfilePage()
        {
           //Profile page initilalization and initialization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.GotoProfilePage(driver);
        }

        [When(@"I create Availabilty of the seller")]
        public void WhenICreateAvailabiltyOfTheSeller()
        {
            //Profile page initilalization and initialization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateAvailabilty(driver);
        }

        [Then(@"Availability should updated sucessfully")]
        public void ThenAvailabilityShouldUpdatedSucessfully()
        {
            ProfilePage profilePageObj = new ProfilePage();
            string newAvailiability = profilePageObj.GetnewAvailability(driver);

            Assert.That(newAvailiability == "Full Time", "Actual availiability and expected do not match");
        }
    }
}
