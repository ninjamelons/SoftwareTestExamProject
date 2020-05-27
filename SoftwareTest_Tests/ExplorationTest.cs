using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareTestExamProject.Functionality;

namespace SoftwareTest_Tests
{
    [TestClass]
    public class ExplorationTest
    {
        [TestMethod]
        [DataRow(1, 1, new[] { 1, 0 }, DisplayName = "Valid move up")]
        [DataRow(1, 0, new[] { 1, 0 }, DisplayName = "Invalid move up")]
        public void TestMoveUp(int playerxcoord, int playerycoord, int[] expectedCoords)
        {
            //Setup
            int mapSizeX = 4, mapSizeY = 4;
            ExplorationFunc exp = new ExplorationFunc(mapSizeX, mapSizeY);

            //Execute
            int[] returnCoords = exp.ButtonUp_Click(new[] { playerxcoord, playerycoord });

            //Assert
            Assert.AreEqual(expectedCoords[0], returnCoords[0]);
        }
    }
}
