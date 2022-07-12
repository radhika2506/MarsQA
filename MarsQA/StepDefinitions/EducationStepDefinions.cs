using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class SellerAddEducationDetailsSteps:CommonDriver
    {
        ProfilePage profilePageObj = new ProfilePage();
        LoginPage loginPageObj = new LoginPage();
        EducationModule EducationModuleObj = new EducationModule();
        [After]
        public void Dispose()
        {
            driver.Close();
        }
        [Given(@"I sign into Mars portal successfully")]
        public void GivenISignIntoMarsPortalSuccessfully()
        {
            //open chrom browser
            driver = new FirefoxDriver();
            // log in steps    
            loginPageObj.LoginSteps(driver);

            //Check if the login was successful
            string HiUser = profilePageObj.GetHiUser(driver);
            Assert.That(HiUser == "Hi Radhika" | HiUser == "Hi", "Hi User not match");
        }
        
        [When(@"I navigate to Education Module")]
        public void WhenINavigateToEducationModule()
        {
            profilePageObj.GoToEducationModule(driver);
        }
        
        [When(@"I add new education record with '(.*)' and '(.*)'")]
        public void WhenIAddNewEducationRecordWithAnd(string p0, string p1)
        {
            EducationModuleObj.AddNewEducation(driver, p0, p1);
        }
        
        [When(@"I update '(.*)' and '(.*)' on existing education record")]
        public void WhenIUpdateAndOnExistingEducationRecord(string p0, string p1)
        {
            EducationModuleObj.EditExistingEducation(driver, p0, p1);
        }
        
        [When(@"I delete existing education record")]
        public void WhenIDeleteExistingEducationRecord()
        {
            EducationModuleObj.DeleteExistingEducation(driver);
        }
        
        [Then(@"the education record should be added successfully with correct '(.*)' and '(.*)'")]
        public void ThenTheEducationRecordShouldBeAddedSuccessfullyWithCorrectAnd(string p0, string p1)
        {

            //Check if the education was created successful
            string NewCountry = EducationModuleObj.GetNewCountryName(driver);
            string NewUniName = EducationModuleObj.GetNewUniversityName(driver);
            string NewTitle = EducationModuleObj.GetNewTitle(driver);
            string NewDegree = EducationModuleObj.GetNewDegree(driver);
            string NewGraduationYear = EducationModuleObj.GetNewGraduationYear(driver);

            Assert.That(NewCountry == "India", "Actual Country do not match");
            Assert.That(NewUniName == p0, "Actual University name do not match");
            Assert.That(NewTitle == "B.Tech", "Actual title do not match");
            Assert.That(NewDegree == p1, "Actual degree do not match");
            Assert.That(NewGraduationYear == "2011", "Actual Graduation Year do not match");
        }
        
        [Then(@"the education record should have updated '(.*)' and '(.*)'")]
        public void ThenTheEducationRecordShouldHaveUpdatedAnd(string p0, string p1)
        {
            // Check if the education was updated successful
            string NewUniName = EducationModuleObj.GetNewUniversityName(driver);
            string NewCountry = EducationModuleObj.GetNewCountryName(driver);
            string NewTitle = EducationModuleObj.GetNewTitle(driver);
            string NewDegree = EducationModuleObj.GetNewDegree(driver);
            string NewGraduationYear = EducationModuleObj.GetNewGraduationYear(driver);

            Assert.That(NewUniName == p0, "updated name do not match");
            Assert.That(NewCountry == "India", "updated Country do not match");
            Assert.That(NewTitle == "B.Tech", "updated title do not match");
            Assert.That(NewDegree == p1, "updated degree do not match");
            Assert.That(NewGraduationYear == "2011", "updated Graduation Year do not match");
        }

        [Then(@"the education record should delete from the education module")]
        public void ThenTheEducationRecordShouldDeleteFromTheEducationModule()
        {
            // Check if the education was deleted successful
            string NewUniName = EducationModuleObj.GetNewUniversityName(driver);
            string NewDegree = EducationModuleObj.GetNewDegree(driver);

            Assert.That(NewUniName != "The University of melbourne", "University name should be deleted still existing");
            Assert.That(NewDegree != "Master", "degree should be deleted still existing");
        }
    }
    
}
