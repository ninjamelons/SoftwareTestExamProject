using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SoftwareTest_Tests
{
    [TestClass]
    public class SeleninumExploration
    {
        //create the reference for the browser  
        IWebDriver driver;

        [TestInitialize]
        public void InitializeTest()
        {
            driver = new ChromeDriver();

            // navigate to URL  
            driver.Navigate().GoToUrl("http://localhost:64848/");

            // identify the Google search text box  
            IWebElement elementName = driver.FindElement(By.Id("MainContent_NameTextBox"));
            //enter the value in the google search text box  
            elementName.SendKeys("Bob");

            // identify the Google search text box  
            IWebElement elementHp = driver.FindElement(By.Id("MainContent_HPTextBox"));
            //enter the value in the google search text box  
            elementHp.SendKeys("1000");

            // identify the Google search text box  
            IWebElement elementDamage = driver.FindElement(By.Id("MainContent_DMGTextBox"));
            //enter the value in the google search text box  
            elementDamage.SendKeys("100");

            //identify the google search button  
            IWebElement elementBut = driver.FindElement(By.Id("MainContent_CreateCharacter"));
            // click on the Google search button  
            elementBut.Click();
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            //close the browser
            driver.Close();
        }

        [TestMethod]
        [DataRow("MainContent_buttonleft", "|___||___||___||___|\r\n|_+_||___||___||___|\r\n|___||___||___||___|\r\n|___||___||___||___|", DisplayName = "Go to left")]
        [DataRow("MainContent_ButtonUp", "|___||_+_||___||___|\r\n|___||___||___||___|\r\n|___||___||___||___|\r\n|___||___||___||___|", DisplayName = "Go to up")]
        [DataRow("MainContent_ButtonRight", "|___||___||___||___|\r\n|___||___||_+_||___|\r\n|___||___||___||___|\r\n|___||___||___||___|", DisplayName = "Go to rigth")]
        [DataRow("MainContent_ButtonDown", "|___||___||___||___|\r\n|___||___||___||___|\r\n|___||_+_||___||___|\r\n|___||___||___||___|", DisplayName = "Go to down")]
        public void TestExplorationMovement(string buttonId, string expectedMap)
        {
            driver.FindElement(By.Id(buttonId)).Click();

            if(driver.Title.Equals("Battle"))
            {
                bool inBattle = true;
                while (inBattle)
                {
                    driver.FindElement(By.Id("AttackButton")).Click();
                    Thread.Sleep(100);
                    if (!driver.Title.Equals("Battle"))
                        inBattle = false;
                }
            }

            string map = driver.FindElement(By.Id("MainContent_mapLabel")).Text;

            Assert.AreEqual(expectedMap, map);
        }
    }
}
