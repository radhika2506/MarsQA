﻿using MarsQA.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        
        public void CloseTestRun()
        {
            driver?.Close();
        }


    }




}
