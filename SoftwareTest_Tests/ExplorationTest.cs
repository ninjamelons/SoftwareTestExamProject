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

        [TestMethod]
        [DataRow(1, 2, new[] { 1, 3 }, DisplayName = "Valid move down")]
        [DataRow(1, 3, new[] { 1, 3 }, DisplayName = "Invalid move down")]
        public void TestMoveDown(int playerxcoord, int playerycoord, int[] expectedCoords)
        {
            //Setup
            int mapSizeX = 4, mapSizeY = 4;
            ExplorationFunc exp = new ExplorationFunc(mapSizeX, mapSizeY);

            //Execute
            int[] returnCoords = exp.ButtonDown_Click(new[] { playerxcoord, playerycoord });

            //Assert
            Assert.AreEqual(expectedCoords[0], returnCoords[0]);
        }

        [TestMethod]
        [DataRow(1, 1, new[] { 0, 1 }, DisplayName = "Valid move down")]
        [DataRow(0, 1, new[] { 0, 1 }, DisplayName = "Invalid move down")]
        public void TestMoveLeft(int playerxcoord, int playerycoord, int[] expectedCoords)
        {
            //Setup
            int mapSizeX = 4, mapSizeY = 4;
            ExplorationFunc exp = new ExplorationFunc(mapSizeX, mapSizeY);

            //Execute
            int[] returnCoords = exp.ButtonLeft_Click(new[] { playerxcoord, playerycoord });

            //Assert
            Assert.AreEqual(expectedCoords[0], returnCoords[0]);
        }

        [TestMethod]
        [DataRow(2, 1, new[] { 3, 1 }, DisplayName = "Valid move down")]
        [DataRow(3, 1, new[] { 3, 1 }, DisplayName = "Invalid move down")]
        public void TestMoveRight(int playerxcoord, int playerycoord, int[] expectedCoords)
        {
            //Setup
            int mapSizeX = 4, mapSizeY = 4;
            ExplorationFunc exp = new ExplorationFunc(mapSizeX, mapSizeY);

            //Execute
            int[] returnCoords = exp.ButtonRight_Click(new[] { playerxcoord, playerycoord });

            //Assert
            Assert.AreEqual(expectedCoords[0], returnCoords[0]);
        }
    }
}
