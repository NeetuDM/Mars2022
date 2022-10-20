using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class SellerSkillsStepDefinitions : CommonDriver
    {
        [Given(@"\[I logged into website]")]
        public void GivenILoggedIntoWebsite()
        {
            //open the Chrome Browser
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"\[When I navigate to profile page]")]
        public void WhenWhenINavigateToProfilePage()
        {
            //Profile page initilalization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.GotoProfilePage(driver);
        }

        [When(@"\[I add skills of the seller]")]
        public void WhenIAddSkillsOfTheSeller()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateSkills(driver);

        }

        [Then(@"\[I should be able to create skill record sucessfully]")]
        public void ThenIShouldBeAbleToCreateSkillRecordSucessfully()
        {
            ProfilePage profilePageObj = new ProfilePage();
            string newSkill = profilePageObj.GetnewSkill(driver);

            Assert.That(newSkill == "Automation Testing", "Actual Code and expected code do not Match");

        }

        [Given(@"\[I logged into the Website]")]
        public void GivenILoggedIntoTheWebsite()
        {
            //open the Chrome Browser
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"\[I navigated to the profile page]")]
        public void WhenINavigatedToTheProfilePage()
        {
            //Profile page initilalization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.GotoProfilePage(driver);
        }

        [When(@"\[I update '([^']*)' on the existing skill record]")]
        public void WhenIUpdateOnTheExistingSkillRecord(string skill)
        {

            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditSkills(driver, skill);
        }

        [Then(@"\[The record should have updated '([^']*)']")]
        public void ThenTheRecordShouldHaveUpdated(string skill)
        {
            ProfilePage profilePageObj = new ProfilePage();

            string GetEditedSkillLevel = profilePageObj.GetEditedSkillLevel(driver, skill);
            Assert.That(GetEditedSkillLevel == skill, "Actual Code and expected code do not Match");
        }

        [Given(@"I logged into the Mars website")]
        public void GivenILoggedIntoTheMarsWebsite()
        {
            //open the Chrome Browser
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }


        [When(@"I navigate to the Profile page")]
        public void WhenINavigateToTheProfilePage()
        {
            //Profile page initilalization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.GotoProfilePage(driver);
        }


        [When(@"I delete the extisting edited skill record")]
        public void WhenIDeleteTheExtistingEditedSkillRecord()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.DeleteSkills(driver);
        }


         [Then(@"Record should be deleted sucessfully")]
         public void ThenRecordShouldBeDeletedSucessfully()
         {
            ProfilePage profilePageObj = new ProfilePage();
            string GetdeleteSkills = profilePageObj.GetdeleteSkills(driver);

           Assert.That(GetdeleteSkills !="Manual Testing", "Actual Code and expected code do not Match");
         }

    }
}
