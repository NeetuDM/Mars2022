using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions : CommonDriver
    {
        [Given(@"\[I logged into the Mars website]")]
        public void GivenILoggedIntoTheMarsWebsite()
        {
            //Open the Chrome Browser
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

        [When(@"\[I navigate to Language tab in the profile page]")]
        public void WhenINavigateToLanguageTabInTheProfilePage()
        {
            
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.GotoProfilePage(driver);

        }


        [When(@"I update '([^']*)' on existing language record")]
        public void WhenIUpdateOnExistingLanguageRecord(string language)
        {

            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditLanguage(driver, language);
        }


        
        [Then(@"The record should have updated '([^']*)'")]
        public void ThenTheRecordShouldHaveUpdated(string language)
        {
            ProfilePage profilePageObj = new ProfilePage();
            string editedLanguageLevel = profilePageObj.GetEditedLanguageLevel(driver, language);
           //string editedLanguageDropdown = profilePageObj.GetEditedLanguageDropdown(driver);


            //Assert if the existing record has been edited.

            Assert.That(editedLanguageLevel == language, "Actual Code and expected code do not Match");
           //Assert.That(editedLanguageDropdown == Level, "Actual Code and expected code do Match");

        }


        [Given(@"I logged into the Mars website\.")]
        public void GivenILoggedIntoTheMarsWebsite_()
        {
            //Open the Chrome Browser
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I navigate to the Language Tab in the profile page\.")]
        public void WhenINavigateToTheLanguageTabInTheProfilePage_()
        {
            //Profile page initilalization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.GotoProfilePage(driver);
        }

        [When(@"I delete the edited language record\.")]
        public void WhenIDeleteTheEditedLanguageRecord_()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.DeleteLanguage(driver);

        }

        [Then(@"Edited Language record should be deleted sucessfully")]
        public void ThenEditedLanguageRecordShouldBeDeletedSucessfully()
        {
           ProfilePage profilePageObj = new ProfilePage();
           string GetDeleteLanguage = profilePageObj.GetDeleteLanguage(driver);

           //Assert if the existing record has been deleted.
           Assert.That(GetDeleteLanguage != "French", "Actual Code and expected code do not Match");

        }

    }

}

