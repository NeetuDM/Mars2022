using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions: CommonDriver
    {
        [Given(@"\[I logged into the Mars website]")]
        public void GivenILoggedIntoTheMarsWebsite()
        {
            //open the Chrome Browser
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

        }

        [When(@"\[I navigate to the Language Tab in the profile page]")]
        public void WhenINavigateToTheLanguageTabInTheProfilePage()
        {
            //Profile page initilalization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.GotoProfilePage(driver);

        }

        [When(@"\[I create new language record on the profile page ]")]
        public void WhenICreateNewLanguageRecordOnTheProfilePage()
        {
            //Profile page initilalization 
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateLanguage(driver);

        }

        [Then(@"\[New Language record should be added sucessfully]")]
        public void ThenNewLanguageRecordShouldBeAddedSucessfully()
        {
            ProfilePage profilePageObj = new ProfilePage();
            string newLanguage = profilePageObj.GetnewLanguage(driver);
            string newLanguageLevel = profilePageObj.GetnewLanguageLevel(driver);

            Assert.That(newLanguage == "English", "Actual Code and expected code do not Match");
            Assert.That(newLanguageLevel == "Fluent", "Actual Code and expected code do Match");

        }
                    

        //[When(@"\[I navigate to Language tab in the profile page]")]
        //public void WhenINavigateToLanguageTabInTheProfilePage()
        //{

            
        //}

        //[When(@"I update '([^']*)', 'Basic language details")]
        //public void WhenIUpdateBasicLanguageDetails(string french)
        //{
            

        //}

        //[Then(@"The existing record for Language '([^']*)', '([^']*)'should be updated sucessfully")]
        //public void ThenTheExistingRecordForLanguageShouldBeUpdatedSucessfully(string french, string basic)
        //{
            

        //}

        //[When(@"\[I delete the edited language record]")]
        //public void WhenIDeleteTheEditedLanguageRecord()
        //{
            

        //}

        //[Then(@"\[Edited Language record should be deleted sucessfully]")]
        //public void ThenEditedLanguageRecordShouldBeDeletedSucessfully()
        //{
            

        //}
    }
}
