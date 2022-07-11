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
        EducationModule EducationModuleObj = new EducationModule();
        CertificationModule CertificationModuleObj = new CertificationModule();
        [After]
        public void Dispose()
        {
            driver.Close();
        }

        [Given(@"I open the  browser and Login with valid credentials")]
        public void GivenIOpenTheBrowserAndLoginWithValidCredentials()
        {
            //open chrom browser
            driver = new FirefoxDriver();
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

        [When(@"I navigate to Education module")]
        public void WhenINavigateToEducationModule()
        {
            profilePageObj.GoToEducationModule(driver); 
        }

        [When(@"I add new education record with '(.*)' and '(.*)'")]
        public void WhenIAddNewEducationRecordWithAnd(string p0, string p1)
        {
            EducationModuleObj.AddNewEducation(driver, p0, p1);
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

         [When(@"I update '(.*)' and '(.*)' on existing education record")]
        public void WhenIUpdateAndOnExistingEducationRecord(string p0, string p1)
        {
            EducationModuleObj.EditExistingEducation(driver,p0,p1);
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

        [When(@"I delete existing education record")]
        public void WhenIDeleteExistingEducationRecord()
        {
            EducationModuleObj.DeleteExistingEducation(driver);
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
        [When(@"I navigate to certification Module")]
        public void WhenINavigateToCertificationModule()
        {
            profilePageObj.GoToCertificationModule(driver);
        }

        [When(@"I add new certification record with '(.*)' and '(.*)'")]
        public void WhenIAddNewCertificationRecordWithAnd(string p0, string p1)
        {
            CertificationModuleObj.AddNewCertificate(driver, p0, p1);
        }

        [Then(@"the certification record should be added successfully with correct '(.*)' and '(.*)'")]
        public void ThenTheCertificationRecordShouldBeAddedSuccessfullyWithCorrectAnd(string p0, string p1)
        {
            //Check if the certification was created successful
            string NewCertificateName = CertificationModuleObj.GetNewCertificateName(driver);
            string NewCertifiedFrom = CertificationModuleObj.GetNewCertifiedFrom(driver);
            string NewCertifiedYear = CertificationModuleObj.GetNewCertifiedYear(driver);

            Assert.That(NewCertificateName == p0, "New Certificate Name do not match");
            Assert.That(NewCertifiedFrom == p1, "New Certified from do not match");
            Assert.That(NewCertifiedYear == "2020", "New Certified Year do not match");
        }

        [When(@"I update '(.*)' and '(.*)' on existing certification record")]
        public void WhenIUpdateAndOnExistingCertificationRecord(string p0, string p1)
        {
            CertificationModuleObj.EditExistingCertificate(driver, p0, p1);
        }

        [Then(@"the certification record should have updated '(.*)' and '(.*)'")]
        public void ThenTheCertificationRecordShouldHaveUpdatedAnd(string p0, string p1)
        {
            //Check if the certification was updated successful
            string NewCertificateName = CertificationModuleObj.GetNewCertificateName(driver);
            string NewCertifiedFrom = CertificationModuleObj.GetNewCertifiedFrom(driver);
            string NewCertifiedYear = CertificationModuleObj.GetNewCertifiedYear(driver);

            Assert.That(NewCertificateName == p0, "updated Certificate Name do not match");
            Assert.That(NewCertifiedFrom == p1, "updated Certified from do not match");
            Assert.That(NewCertifiedYear == "2020", "updated Certified Year do not match");
        }

        [When(@"I delete existing certification record")]
        public void WhenIDeleteExistingCertificationRecord()
        {
            CertificationModuleObj.DeleteExistingCertificate(driver);
        }

        [Then(@"the certification record should disappear from the certification module")]
        public void ThenTheCertificationRecordShouldDisappearFromTheCertificationModule()
        {
            //check if the certification record deleted successful
            string NewCertificateName = CertificationModuleObj.GetNewCertificateName(driver);
            string NewCertifiedFrom = CertificationModuleObj.GetNewCertifiedFrom(driver);

            Assert.That(NewCertificateName != "Best Tutors", "Certificate Name should be deleted still existing");
            Assert.That(NewCertifiedFrom != "University of Canterbury", "Certified From should be deleted still existing");
        }



    }
}
