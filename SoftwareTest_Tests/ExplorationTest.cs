using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareTestExamProject.Functionality;

namespace SoftwareTest_Tests
{
    [TestClass]
    public class ExplorationTest
    {
        private ExplorationFunc _exp;

        [TestInitialize]
        public void TestInit()
        {
            _exp = new ExplorationFunc(4, 4);
        }

        [TestMethod]
        [DataRow(1, 1, new[] { 1, 0 }, DisplayName = "Valid move up")]
        [DataRow(1, 0, new[] { 1, 0 }, DisplayName = "Invalid move up")]
        public void TestMoveUp(int playerxcoord, int playerycoord, int[] expectedCoords)
        {
            //Execute
            int[] returnCoords = _exp.ButtonUp_Click(new[] { playerxcoord, playerycoord });

            //Assert
            Assert.AreEqual(expectedCoords[1], returnCoords[1]);
        }

        [TestMethod]
        [DataRow(1, 2, new[] { 1, 3 }, DisplayName = "Valid move down")]
        [DataRow(1, 3, new[] { 1, 3 }, DisplayName = "Invalid move down")]
        public void TestMoveDown(int playerxcoord, int playerycoord, int[] expectedCoords)
        {
            //Execute
            int[] returnCoords = _exp.ButtonDown_Click(new[] { playerxcoord, playerycoord });

            //Assert
            Assert.AreEqual(expectedCoords[1], returnCoords[1]);
        }

        [TestMethod]
        [DataRow(1, 1, new[] { 0, 1 }, DisplayName = "Valid move down")]
        [DataRow(0, 1, new[] { 0, 1 }, DisplayName = "Invalid move down")]
        public void TestMoveLeft(int playerxcoord, int playerycoord, int[] expectedCoords)
        {
            //Execute
            int[] returnCoords = _exp.ButtonLeft_Click(new[] { playerxcoord, playerycoord });

            //Assert
            Assert.AreEqual(expectedCoords[0], returnCoords[0]);
        }

        [TestMethod]
        [DataRow(2, 1, new[] { 3, 1 }, DisplayName = "Valid move down")]
        [DataRow(3, 1, new[] { 3, 1 }, DisplayName = "Invalid move down")]
        public void TestMoveRight(int playerxcoord, int playerycoord, int[] expectedCoords)
        {
            //Execute
            int[] returnCoords = _exp.ButtonRight_Click(new[] { playerxcoord, playerycoord });

            //Assert
            Assert.AreEqual(expectedCoords[0], returnCoords[0]);
        }

        [TestMethod]
        [DynamicData("EncounterData")]
        public void TestRandomEncounter(int encounterNo, bool expectedEncounter)
        {
            bool encounter = _exp.Encounter(encounterNo);

            //Assert
            Assert.AreEqual(encounter, expectedEncounter);
        }

        private static IEnumerable<object[]> EncounterData =>
            new[]
            {
                new object[] {ExplorationFunc.EncounterNo, true},
                new object[] {ExplorationFunc.EncounterNo + 1, false}
            };
    }
}
