using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            //maximise the window
            driver.Manage().Window.Maximize();
            //Navigate Url
            driver.Navigate().GoToUrl("http://localhost:5000/");
            try
            {
                WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div/div/div/div/div/div[1]/div/a", 5);
                //click on signIn
                driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div[1]/div/a")).Click();
                //input valid email
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("radhika.surukanti@gmail.com");
                //input valid password
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("radhika123");
                //click on login
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Mars Portal page did not launch.", ex.Message);
            }

            
        }
      
       

    }
}
