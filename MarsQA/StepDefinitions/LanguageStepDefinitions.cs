using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class SellerAddLanguageDetailsSteps : CommonDriver
    {
        ProfilePage profilePageObj = new ProfilePage();
        LoginPage loginPageObj = new LoginPage();
        LangauageModule LangauageModuleObj = new LangauageModule();
        [After]
        public void Dispose()
        {
            driver.Close();
        }

        [Given(@"I logged into Mars portal successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            //open chrom browser
            driver = new FirefoxDriver();
            // log in steps    
            loginPageObj.LoginSteps(driver);
            //Check if the login was successful
            string HiUser = profilePageObj.GetHiUser(driver);
            Assert.That(HiUser == "Hi Radhika" | HiUser == "Hi", "Hi User not match");
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

        [When(@"I update '(.*)'on existing language record")]
        public void WhenIUpdateOnExistingLanguageRecord(string p0)
        {
            LangauageModuleObj.EditExistingLanguage(driver, p0);
        }

        [When(@"I delete existing language record")]
        public void WhenIDeleteExistingLanguageRecord()
        {
            LangauageModuleObj.DeleteExistingLanguage(driver);
        }

        [Then(@"the '(.*)' records should be added in language module successfully")]
        public void ThenTheRecordsShouldBeAddedInLanguageModuleSuccessfully(string p0)
        {
            // Check if the language was created successful
            string NewLanguage = LangauageModuleObj.GetNewLanguage(driver);
            Assert.That(NewLanguage == p0, "added language do not match");
        }

        [Then(@"the language record should have updated '(.*)'")]
        public void ThenTheLanguageRecordShouldHaveUpdated(string p0)
        {
            //Check if the language was updated successful
            string NewLanguage = LangauageModuleObj.GetNewLanguage(driver);
            Assert.That(NewLanguage == p0, "Updated language do not match");
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
