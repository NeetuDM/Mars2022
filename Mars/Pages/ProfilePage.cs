using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Mars.Pages
{
    public class ProfilePage
    {

        public void GotoProfilePage(IWebDriver driver)
        {

            //Nevigate to Profile Page (Identify the Profile Button and click)
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[1]/div/a[2]\r\n"));
            profileButton.Click();
            Thread.Sleep(1000);

            // Assert if user is able to go to profile page
            IWebElement newProfileNAme = driver.FindElement(By.XPath("//div[@class='ui fluid accordion']"));
            Assert.That(newProfileNAme.Text == "Neetu Dhoundiyal", "Actual name and Expected name do not match");

        }

        public void CreateAvailabilty(IWebDriver driver)
        {
            Thread.Sleep(3000);
            //Click on the Availablity Dropdown menu and select full time
            IWebElement editAvailaibalityButton = driver.FindElement(By.XPath("//i[@class='right floated outline small write icon']"));
            editAvailaibalityButton.Click();
            Thread.Sleep(3000);

            IWebElement availabilityDropdownmenu = driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown']"));
            //("//div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            availabilityDropdownmenu.Click();
            Thread.Sleep(2000);

            IWebElement fulltimeOption = driver.FindElement(By.XPath("//option[@value='1']"));
            //div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div
            fulltimeOption.Click();
            Thread.Sleep(2000);

            // Assert if Availaibility has been updated
            //IWebElement newAvailiability = driver.FindElement(By.XPath("(//div[@class='right floated content'])[2]"));
            //Assert.That(newAvailiability.Text == "Full Time", "Actual availiability and expected do not match");

        }
        public string GetnewAvailability(IWebDriver driver)
        {

            IWebElement newAvailiability = driver.FindElement(By.XPath("(//div[@class='right floated content'])[2]"));
            return newAvailiability.Text;
        }


        public void CreateLanguage(IWebDriver driver)
        {
            Thread.Sleep(4000);
            //Create Languages
            //Identify the Languages Button and click
            IWebElement languagesButton = driver.FindElement(By.XPath("//a[@data-tab='first']"));

            Thread.Sleep(3000);
            languagesButton.Click();
            Thread.Sleep(3000);

            Thread.Sleep(3000);
            //Identify the addnewButton and click
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();
            Thread.Sleep(3000);

            //Identify the addlanguageTextBox and enter text
            IWebElement addlanguageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addlanguageTextbox.SendKeys("English");
            Thread.Sleep(3000);

            //Identify the chooselanguagelevel dropdown and select the option
            IWebElement chooselanguagelevelDropdown = driver.FindElement(By.XPath("//*[@id=\'account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooselanguagelevelDropdown.Click();
            Thread.Sleep(3000);

            //Identify the Fluentoptiondropdown and select the option
            IWebElement Fluentoptiondropdown = driver.FindElement(By.XPath("//option[@value='Fluent']"));
            //*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            Fluentoptiondropdown.Click();
            Thread.Sleep(1000);

            //Identify the Addbutton and click
            IWebElement Addbutton = driver.FindElement(By.XPath("//input[@type='button']"));
            //*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]\r\n"));
            Addbutton.Click();
            Thread.Sleep(3000);

            // Assert that Language record has been created.

            //Nevigate to Profile Page(Identify the Profile Button and click)
            //IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[1]/div/a[2]\r\n"));
            //profileButton.Click();
            //Thread.Sleep(5000);

            //IWebElement newLanguage = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            //IWebElement newLanguageLevel = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));

            //Assert.That(newLanguage.Text == "English", "Actual Code and expected code do not Match");
            //Assert.That(newLanguageLevel.Text == "Fluent", "Actual Code and expected code do Match");

        }

        public string GetnewLanguage(IWebDriver driver)
        {

            IWebElement newLanguage = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newLanguage.Text;
        }

        public string GetnewLanguageLevel(IWebDriver driver)
        {

            IWebElement newLanguageLevel = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));


            return newLanguageLevel.Text;
        }
        public void EditLanguage(IWebDriver driver, string language)

        {
            Thread.Sleep(4000);
            //Identify the Languages Button and click
            IWebElement languagesButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languagesButton.Click();
            Thread.Sleep(3000);


            Thread.Sleep(3000);
            //Edit Languages
            //Identify the editButton and click
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/span[1]/i"));
            editButton.Click();
            Thread.Sleep(3000);
                        
            Thread.Sleep(3000);
            IWebElement editlanguageTextbox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editlanguageTextbox.Clear();
            editlanguageTextbox.SendKeys(language);
            Thread.Sleep(3000);

            //Identify the editlevelDropdown Button and click
            IWebElement editLevelDropdown = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]"));
            editLevelDropdown.Click();
            Thread.Sleep(3000);

            //Identify the Basictoptiondropdown and select the option
            IWebElement Basicoptiondropdown = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
            Basicoptiondropdown.Click();
            Thread.Sleep(3000);

            //Identify the updateButton and click
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]\r\n"));
            updateButton.Click();
            Thread.Sleep(2000);

            Thread.Sleep(4000);
            //Nevigate to Profile Page(Identify the Profile Button and click)
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[1]/div/a[2]\r\n"));
            profileButton.Click();
            Thread.Sleep(4000);

        }
        // Assert that language record has been edited
        public string GetEditedLanguageLevel(IWebDriver driver, string language)
        {
            IWebElement editedLanguageLevel = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedLanguageLevel.Text;


            //public string GetEditedLanguageDropdown(IWebDriver driver)
            //{
            //IWebElement editedLanguageDropdown = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            //return editedLanguageDropdown.Text;

            //}
        }
        public void DeleteLanguage(IWebDriver driver)

        {
            Thread.Sleep(4000);
            //Go to the profile page where edited Language record will be 
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[1]/div/a[2]\r\n"));
            profileButton.Click();
            Thread.Sleep(4000);

            //Identify the Languages Button and click
            IWebElement languagesButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languagesButton.Click();
            Thread.Sleep(3000);

            //Identify the deleteButton and click
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deleteButton.Click();
            Thread.Sleep(4000);
            

        } 
        public string GetDeleteLanguage(IWebDriver driver)

            {
                IWebElement deletedLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
                return null;
            
        }
        public void CreateSkills(IWebDriver driver)

        {
            Thread.Sleep(4000);
            //Identify the skillsButton and click
            IWebElement skillsButton = driver.FindElement(By.XPath("//a[@data-tab='second']"));
            skillsButton.Click();
            Thread.Sleep(1000);

            //Identify the AddNewButton and click
            IWebElement addNewButton = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            addNewButton.Click();
            Thread.Sleep(1000);

            //Identify AddSkillTextbox and enter value
            IWebElement addskillTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            addskillTextbox.SendKeys("Automation Testing");
            Thread.Sleep(3000);

            //Identify the ChooseSkillLevel Dropdown and select the option
            IWebElement chooseskillLevelDropdown = driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
            chooseskillLevelDropdown.Click();
            Thread.Sleep(1000);

            //Identify the Beginnertoptiondropdown and select the option
            IWebElement Beginnertoptiondropdown = driver.FindElement(By.XPath("//option[@value='Beginner']"));
            Beginnertoptiondropdown.Click();
            Thread.Sleep(1000);

            //Identify the AddButton and click
            IWebElement AddButton = driver.FindElement(By.XPath("//input[@type='button']"));
            AddButton.Click();
            Thread.Sleep(1000);
                      
            //IWebElement NewSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            //Assert.That(NewSkills.Text== "Automation Testing", "Actual Skill and expected Skill do Match");

        }    
            //Assert if new record for skills has been added
            public string GetnewSkill(IWebDriver driver)
            {

             IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
             return newSkill.Text;
            }

        public void EditSkills(IWebDriver driver, string skills)

        {
            Thread.Sleep(4000);
            //Identify the skillsButton and click
            IWebElement skillsButton = driver.FindElement(By.XPath("//a[@data-tab='second']"));
            //*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsButton.Click();
            Thread.Sleep(2000);

            //Identify the editButton and click
            IWebElement editSkillButton = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editSkillButton.Click();
            Thread.Sleep(3000);

            IWebElement editskillTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            editskillTextbox.Clear();
            editskillTextbox.SendKeys("Manual Testing");
            Thread.Sleep(3000);

            IWebElement editSkillLevelDropdown = driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
            editSkillLevelDropdown.Click();
            Thread.Sleep(3000);

            //Identify the IntermediateLeveldropdown and select the option
            IWebElement IntermediateLeveldropdown = driver.FindElement(By.XPath("//option[@value='Intermediate']"));
            IntermediateLeveldropdown.Click();
            Thread.Sleep(2000);

            //Identify the updateSkillButton and click
            IWebElement updateSkillButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateSkillButton.Click();
            Thread.Sleep(2000);

            //Assert the record on the Skills has been edited sucessfully
            //Identify the skillsButton and click
            IWebElement skillsButton1 = driver.FindElement(By.XPath("//a[@data-tab='second']"));
            skillsButton.Click();
            Thread.Sleep(1000);

            //IWebElement editSkillTextBox = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            //IWebElement editSkillLevelDropdown1 = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));

            //Assert.That(editSkillTextBox.Text == "Manual Testing", "Actual Code and expected code do not Match");
            //Assert.That(editSkillLevelDropdown1.Text == "Intermediate", "Actual Code and expected code do Match");

        }
        //Assert that new record has been edited.
        public string GetEditedSkillLevel(IWebDriver driver, string skill)
        {
            IWebElement editedSkill = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedSkill.Text;
        }

        public void DeleteSkills(IWebDriver driver)

        {
            Thread.Sleep(3000);
            //Go to the profile page where edited Skills record will be 
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[1]/div/a[2]\r\n"));
            profileButton.Click();
            Thread.Sleep(3000);

            //Identify the skillsButton and click
            IWebElement skillsButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            //("//a[@data-tab='second']"));
            skillsButton.Click();
            Thread.Sleep(3000);

            //Identify the deleteButton and click
            IWebElement deleteButton1 = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deleteButton1.Click();
            Thread.Sleep(3000);

        }
        
        //Assert that new record has been deleted.
        public string GetdeleteSkills(IWebDriver driver)
        { 
            IWebElement deleteSkills = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return null;
        
        }
    }

}