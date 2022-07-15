using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class SellerAddCertificationDetailsSteps : CommonDriver
    {
        readonly ProfilePage profilePageObj;
        readonly LoginPage loginPageObj;
        readonly CertificationModule CertificationModuleObj;
        public SellerAddCertificationDetailsSteps()
        {
            //open chrom browser
            driver = new FirefoxDriver();
            profilePageObj = new ProfilePage(driver);
            loginPageObj = new LoginPage(driver);
            CertificationModuleObj = new CertificationModule(driver);
        }
       
        [After]
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Close();
            }
        }

        [Given(@"I log into Mars portal successfully")]
        public void GivenILogIntoMarsPortalSuccessfully()
        {
            // log in steps    
            loginPageObj.LoginSteps(driver);

           // Check if the login was successful
            string HiUser = profilePageObj.GetHiUser();
            Assert.That(HiUser == "Hi Radhika" | HiUser == "Hi", "Hi User not match");
        }

        [When(@"I navigate to certifications Module")]
        public void WhenINavigateToCertificationsModule()
        {

            profilePageObj.GoToCertificationModule();
        }

        [When(@"I add new certifications record with '(.*)' and '(.*)'")]
        public void WhenIAddNewCertificationsRecordWithAnd(string p0, string p1)
        {
            CertificationModuleObj.AddNewCertificate( p0, p1);
        }

        [When(@"I update '(.*)' and '(.*)' on existing certifications record")]
        public void WhenIUpdateAndOnExistingCertificationsRecord(string p0, string p1)
        {
            CertificationModuleObj.EditExistingCertificate( p0, p1);
        }

        [When(@"I delete existing certifications record")]
        public void WhenIDeleteExistingCertificationsRecord()
        {
            CertificationModuleObj.DeleteExistingCertificate();
        }

        [Then(@"the certifications record should be added successfully with correct '(.*)' and '(.*)'")]
        public void ThenTheCertificationsRecordShouldBeAddedSuccessfullyWithCorrectAnd(string p0, string p1)
        {
            //Check if the certification was created successful
            string NewCertificateName = CertificationModuleObj.GetNewCertificateName();
            string NewCertifiedFrom = CertificationModuleObj.GetNewCertifiedFrom();
            string NewCertifiedYear = CertificationModuleObj.GetNewCertifiedYear();

            Assert.That(NewCertificateName == p0, "New Certificate Name do not match");
            Assert.That(NewCertifiedFrom == p1, "New Certified from do not match");
            Assert.That(NewCertifiedYear == "2020", "New Certified Year do not match");
        }

        [Then(@"the certifications record should have updated '(.*)' and '(.*)'")]
        public void ThenTheCertificationsRecordShouldHaveUpdatedAnd(string p0, string p1)
        {
            //Check if the certification was updated successful
            string NewCertificateName = CertificationModuleObj.GetNewCertificateName();
            string NewCertifiedFrom = CertificationModuleObj.GetNewCertifiedFrom();
            string NewCertifiedYear = CertificationModuleObj.GetNewCertifiedYear();

            Assert.That(NewCertificateName == p0, "updated Certificate Name do not match");
            Assert.That(NewCertifiedFrom == p1, "updated Certified from do not match");
            Assert.That(NewCertifiedYear == "2020", "updated Certified Year do not match");
        }

        [Then(@"the certifications record should disappear from the certification module")]
        public void ThenTheCertificationsRecordShouldDisappearFromTheCertificationModule()
        {
                 //check if the certification record deleted successful
                string NewCertificateName = CertificationModuleObj.GetNewCertificateName();
                string NewCertifiedFrom = CertificationModuleObj.GetNewCertifiedFrom();

                Assert.That(NewCertificateName != "Best Student", "Certificate Name should be deleted still existing");
                Assert.That(NewCertifiedFrom != "University of Auckland", "Certified From should be deleted still existing");
            
        }
    }
}
