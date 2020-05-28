using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareTestExamProject.Functionality;

namespace SoftwareTest_Tests
{
    [TestClass]
    public class CharacterTest
    {
        Inputs inputs;

        #region character 
        [TestInitialize]
        public void InitializeInputs()
        {
            inputs = new Inputs();
        }

        [TestMethod]
        [DataRow("B", DisplayName = "String length = 1 Lower Valid")]
        [DataRow("gggggggggggggggggggggggggggggggggggggggg", DisplayName = "String length = 40 Upper Valid")]
        [DataRow("abcæøåABCÆØÅ1234", DisplayName = "Valid characters")]
        public void TestValidNameInputs(string name)
        {
            bool actualPass = false;

            //Setup
            string result = inputs.NameInput(name);

            if (!result.Equals("-1"))
                actualPass = true;

            //Assert
            Assert.IsTrue(actualPass);
        }

        [TestMethod]
        [DataRow("", DisplayName = "String length = 0 Lower Invalid")]
        [DataRow("ggggggggggggggggggggggggggggggggggggggg41", DisplayName = "String length = 41 Upper Invalid")]
        [DataRow("†‡™", DisplayName = "Invalid Symbols")]
        public void TestInvalidNameInputs(string name)
        {
            bool actualPass = false;

            //Setup
            string result = inputs.NameInput(name);

            if (!result.Equals("-1"))
                actualPass = true;

            //Assert
            Assert.IsFalse(actualPass);
        }

        [TestMethod]
        [DataRow("0", false, DisplayName = "Lower Invalid")]
        [DataRow("1001", false, DisplayName = "Upper Invalid")]
        [DataRow("1", true, DisplayName = "Lower Valid")]
        [DataRow("1000", true, DisplayName = "Upper Valid")]
        [DataRow("a", false, DisplayName = "Invalid Characters")]
        public void TestHealthBoundariesAndCharacters(string health, bool passed)
        {
            bool actualPass = false;

            //Setup
            int result = inputs.HPInput(health);

            if (result != -1)
                actualPass = true;

            //Assert
            Assert.AreEqual(passed, actualPass);
        }

        [TestMethod]
        [DataRow("0", false, DisplayName = "Lower Invalid")]
        [DataRow("101", false, DisplayName = "Upper Invalid")]
        [DataRow("1", true, DisplayName = "Lower Valid")]
        [DataRow("100", true, DisplayName = "Upper Valid")]
        [DataRow("fifty", false, DisplayName = "Invalid Characters")]
        public void TestDamageBoundariesAndCharacters(string damage, bool passed)
        {
            bool actualPass = false;

            //Setup
            int result = inputs.DMGInput(damage);

            if (result != -1)
                actualPass = true;

            //Assert
            Assert.AreEqual(passed, actualPass);
        }
        #endregion

        #region Player combo invalid inputs

        //testing combinations of multi invalid inputs
        [TestMethod]
        [DataRow("<<<>>>>", "500", "256", false, DisplayName = "Invalid name and damage")]
        [DataRow("Bob", "1234", "256", false, DisplayName = "Invalid health and damage")]
        [DataRow("<<>>><<>>><", "1234", "50", false, DisplayName = "Invalid health and name")]
        [DataRow("<<>>><<>>><", "1234", "256", false, DisplayName = "Invalid health and name and damage")]
        public void TestInputFieldCombinations(string name, string health, string damage, bool passed)
        {
            bool actualPass = false;
            //test new for CI
            //Setup
            string nameRes = inputs.NameInput(name);
            int hpRes = inputs.HPInput(health);
            int dmgRes = inputs.DMGInput(damage);

            Player player = new Player(nameRes, hpRes, dmgRes);

            if (!player.Name.Equals("-1") && player.MaxHp != -1 && player.Damage != -1)
                actualPass = true;

            //Assert
            Assert.AreEqual(passed, actualPass);
        }

        #endregion
    }
}
