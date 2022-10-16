using Mars.Pages;
using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class SellerSkillsStepDefinitions: CommonDriver
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

        //[Given(@"\[I logged into the Website]")]
        //public void GivenILoggedIntoTheWebsite()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"\[I navigated to the profile page]")]
        //public void WhenINavigatedToTheProfilePage()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"\[I edit the existing skill record]")]
        //public void WhenIEditTheExistingSkillRecord()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"\[The skill record should be edited sucessfully]")]
        //public void ThenTheSkillRecordShouldBeEditedSucessfully()
        //{
        //    throw new PendingStepException();
        //}

        //[Given(@"\[I navigated to the profile page]")]
        //public void GivenINavigatedToTheProfilePage()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"\[I delete the edited skill record]")]
        //public void WhenIDeleteTheEditedSkillRecord()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"\[Edited skill record should be delted sucessfully]")]
        //public void ThenEditedSkillRecordShouldBeDeltedSucessfully()
        //{
        //    throw new PendingStepException();
        //}
    }
}
