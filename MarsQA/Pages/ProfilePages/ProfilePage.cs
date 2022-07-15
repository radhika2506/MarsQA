using MarsQA.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    class ProfilePage
    {
        private IWebDriver driver;

        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetHiUser()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div/div[1]/div[2]/div/span", 10);
            IWebElement HiUser = driver.FindElement(By.XPath("//div/div[1]/div[2]/div/span"));
            return HiUser.Text;
        }


        public void GoToLanguageModule()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10);
            IWebElement LanguageModule = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            LanguageModule.Click();
        }
        public void GoToEducationModule()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10);
            IWebElement LanguageModule = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            LanguageModule.Click();
        }
        public void GoToCertificationModule()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10);
            IWebElement CertificationModule = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            CertificationModule.Click();
        }

    }
}
