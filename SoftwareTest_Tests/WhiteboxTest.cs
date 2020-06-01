using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareTestExamProject.Functionality;

namespace SoftwareTest_Tests
{
    [TestClass]
    public class WhiteboxTest
    {
        //Test cases for 100% decision coverage.
        [TestMethod]
        [DataRow(1, 5, 2, DisplayName = "Player 0.2% of Heals")]
        [DataRow(4, 5, 5, DisplayName = "Player 0.8% of Hp")]
        [DataRow(5, 5, 5, DisplayName = "Player Full Hp")]
        public void Test_Heal_combat_action(int playerHp, int maxHp, int expectedHp)
        {
            Player player = new Player("name", maxHp, 10)
            {
                CurrentHp = playerHp
            };

            player.Heal();

            Assert.AreEqual(expectedHp, player.CurrentHp);
        }

        [TestMethod]
        [DataRow(1, 2, 1, 2, DisplayName = "100% decision coverage")]
        public void Test_Map_Creation(int mapsizeX, int mapsizeY, int playerCoordsX, int playerCoordsY)
        {

        }
    }
}
