using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinions

{
    [Binding]
    class ProfileStepDefinitions : CommonDriver
    {
        ProfilePage profilePageObj = new ProfilePage();
        LoginPage loginPageObj = new LoginPage();
        LangauageModule LangauageModuleObj = new LangauageModule();

        [After]
        public void Dispose()
        {
            driver.Close();
        }


        [Given(@"I open browser and goto Url")]

        public void GivenIOpenBrowserAndGotoUrl()
        {
            //open chrom browser
            driver = new FirefoxDriver();
            // log in steps    
            loginPageObj.LoginSteps(driver);

        }

        [When(@"I give valid Email and Password")]
        public void WhenIGiveValidEmailAndPassword()
        {
            // log in steps    
            loginPageObj.LoginSteps(driver);

        }

        [Then(@"I logged into poratl Successfully")]
        public void ThenILoggedIntoPoratlSuccessfully()
        {
            //Check if the login was successful
            string HiUser = profilePageObj.GetHiUser(driver);
            Assert.That(HiUser == "Hi Radhika" | HiUser == "Hi", "Hi User not match");
        }


        [Given(@"I logged into Mars portal successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            //open chrom browser
            driver = new FirefoxDriver();

            //log in mars portal
            loginPageObj.LoginSteps(driver);
        }

       

        [When(@"I navigate to language module")]
        public void WhenINavigateToLanguageModule()
        {
            profilePageObj.GoToLanguageModule(driver);
        }

        [When(@"I add new '(.*)' records on lauguange module")]
        public void WhenIAddNewRecordsOnLauguangeModule(string p0)
        {
            LangauageModuleObj.AddLanguage(driver, p0);
        }

        [Then(@"the '(.*)' records should be added in language module successfully")]
        public void ThenTheRecordsShouldBeAddedInLanguageModuleSuccessfully(string p0)
        {
           // Check if the language was created successful
            string NewLanguage = LangauageModuleObj.GetNewLanguage(driver);
            Assert.That(NewLanguage == p0, "added language do not match");
        }

        [When(@"I update '(.*)'on existing language record")]
        public void WhenIUpdateOnExistingLanguageRecord(string p0)
        {
            LangauageModuleObj.EditExistingLanguage(driver, p0);
        }

        [Then(@"the language record should have updated '(.*)'")]
        public void ThenTheLanguageRecordShouldHaveUpdated(string p0)
        {
            //Check if the language was updated successful
            string NewLanguage = LangauageModuleObj.GetNewLanguage(driver);
            Assert.That(NewLanguage == p0, "Updated language do not match");
        }

        [When(@"I delete existing language record")]
        public void WhenIDeleteExistingLanguageRecord()
        {
            LangauageModuleObj.DeleteExistingLanguage(driver);
        }

        [Then(@"the language record should disappear from the language module")]
        public void ThenTheLanguageRecordShouldDisappearFromTheLanguageModule()
        {
            //Check if the language was deleted successful
          
            String NewLanguage = LangauageModuleObj.GetNewLanguage(driver);
            Assert.That(NewLanguage != "Hindi", "language should be deleted still existing");  
        }

    }
}
