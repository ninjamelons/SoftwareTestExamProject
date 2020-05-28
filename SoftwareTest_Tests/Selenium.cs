using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SoftwareTest_Tests
{
    [TestClass]
    public class Selenium
    {
        const string nameInvalid = "Please input a valid Name(a-Å/numbers). ";
        const string hpInvalid = "Please input a valid number for Health (1-1000). ";
        const string damageInvalid = "Please input a valid number for Damage (1-100).";

        [TestMethod]
        [DataRow("<<<>>>>", "500", "256", nameInvalid + damageInvalid, DisplayName = "Invalid name and damage")]
        [DataRow("Bob", "1234", "256", hpInvalid + damageInvalid, DisplayName = "Invalid health and damage")]
        [DataRow("<<>>><<>>><", "1234", "50", nameInvalid + hpInvalid, DisplayName = "Invalid health and name")]
        [DataRow("<<>>><<>>><", "1234", "256", nameInvalid + hpInvalid + damageInvalid, DisplayName = "Invalid health and name and damage")]
        public void TestInvalidCreate(string name, string health, string damage, string msg)
        {
            //create the reference for the browser  
            IWebDriver driver = new ChromeDriver();

            // navigate to URL  
            driver.Navigate().GoToUrl("http://localhost:64848/");
            //Thread.Sleep(2000);

            #region create

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
           // Thread.Sleep(1000);

            IWebElement elementLabel = driver.FindElement(By.Id("MainContent_ErrorLabel"));
            elementLabel.Text.Equals(msg);

            #endregion
            //close the browser
            driver.Close();
        }

        [TestMethod]
        public void Testvalidgameplay()
        {
            //create the reference for the browser  
            IWebDriver driver = new ChromeDriver();

            // navigate to URL  
            driver.Navigate().GoToUrl("http://localhost:64848/");
            Thread.Sleep(2000);

            #region create

            // identify the Google search text box  
            IWebElement elementName = driver.FindElement(By.Id("MainContent_NameTextBox"));
            //enter the value in the google search text box  
            elementName.SendKeys("Bob");

            // identify the Google search text box  
            IWebElement elementHp = driver.FindElement(By.Id("MainContent_HPTextBox"));
            //enter the value in the google search text box  
            elementHp.SendKeys("50");

            // identify the Google search text box  
            IWebElement elementDamage = driver.FindElement(By.Id("MainContent_DMGTextBox"));
            //enter the value in the google search text box  
            elementDamage.SendKeys("50");

            //identify the google search button  
            IWebElement elementBut = driver.FindElement(By.Id("MainContent_CreateCharacter"));
            // click on the Google search button  
            elementBut.Click();
            Thread.Sleep(3000);
            //close the browser
            #endregion

            #region explore




            #endregion

            driver.Close();


        }
    }
}
