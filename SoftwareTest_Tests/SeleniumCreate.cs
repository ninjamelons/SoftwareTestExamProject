using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SoftwareTestExamProject.Functionality;

namespace SoftwareTest_Tests
{
    [TestClass]
    public class SeleniumCreate
    {
        const string nameInvalid = "Please input a valid Name (a-Å/numbers).";
        const string hpInvalid = "Please input a valid number for Health (1-1000).";
        const string damageInvalid = "Please input a valid number for Damage (1-100).";


        //create the reference for the browser  
        IWebDriver driver;

        [TestInitialize]
        public void InitializeTest()
        {
            driver = new ChromeDriver();

            // navigate to URL  
            driver.Navigate().GoToUrl("http://localhost:80/");
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            //close the browser
            driver.Close();
        }

        [TestMethod]
        [DataRow("<<<>>>>", "500", "256", nameInvalid + damageInvalid, DisplayName = "Invalid name and damage")]
        [DataRow("Bob", "1234", "256", hpInvalid + damageInvalid, DisplayName = "Invalid health and damage")]
        [DataRow("<<>>><<>>><", "1234", "50", nameInvalid + hpInvalid, DisplayName = "Invalid health and name")]
        [DataRow("<<>>><<>>><", "1234", "256", nameInvalid + hpInvalid + damageInvalid, DisplayName = "Invalid health and name and damage")]
        public void TestInvalidCharacterCreate(string name, string health, string damage, string msg)
        {
            // identify the Google search text box  
            IWebElement elementName = driver.FindElement(By.Id("MainContent_NameTextBox"));
            //enter the value in the google search text box  
            elementName.SendKeys(name);
            
            // identify the Google search text box  
            IWebElement elementHp = driver.FindElement(By.Id("MainContent_HPTextBox"));
            //enter the value in the google search text box  
            elementHp.SendKeys(health);

            // identify the Google search text box  
            IWebElement elementDamage = driver.FindElement(By.Id("MainContent_DMGTextBox"));
            //enter the value in the google search text box  
            elementDamage.SendKeys(damage);

            //identify the google search button  
            IWebElement elementBut = driver.FindElement(By.Id("MainContent_CreateCharacter"));
            // click on the Google search button  
            elementBut.Click();
            //Thread.Sleep(1000);

            IWebElement elementLabel = driver.FindElement(By.Id("MainContent_ErrorLabel"));

            Assert.AreEqual(msg, elementLabel.Text);
        }

        [TestMethod]
        [DataRow("Bob", "500", "50", DisplayName = "Create player")]
        public void TestvalidCharacterCreate(string name, string health, string damage)
        {
            // identify the Google search text box  
            IWebElement elementName = driver.FindElement(By.Id("MainContent_NameTextBox"));
            //enter the value in the google search text box  
            elementName.SendKeys(name);

            // identify the Google search text box  
            IWebElement elementHp = driver.FindElement(By.Id("MainContent_HPTextBox"));
            //enter the value in the google search text box  
            elementHp.SendKeys(health);
          
            // identify the Google search text box  
            IWebElement elementDamage = driver.FindElement(By.Id("MainContent_DMGTextBox"));
            //enter the value in the google search text box  
            elementDamage.SendKeys(damage);

            //identify the google search button  
            IWebElement elementBut = driver.FindElement(By.Id("MainContent_CreateCharacter"));
            // click on the Google search button  
            elementBut.Click();

            var handle = driver.Title;
            Assert.AreEqual("Exploration - My ASP.NET Application", handle);
        }
    }
}
