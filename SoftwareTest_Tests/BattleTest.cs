using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareTestExamProject.Functionality;
using SoftwareTestExamProject;

namespace SoftwareTest_Tests
{
    [TestClass]
    public class BattleTest
    {

        #region Player Attacks Enemy

        //Testing player attack, enemy attack
        [TestMethod]
        [DataRow(1, "Elf", 500, 50, 1, "Rat", 500, 15, DisplayName = "Player Attack ")]
        [DataRow(1, "Elf", 500, 1, 1, "Rat", 500, 15, DisplayName = "Player Attack - min damage")]
        [DataRow(1, "Elf", 500, 100, 1, "Rat", 500, 15, DisplayName = "Player Attack - max damage")]
        public void Test_BattleSim_Player_Attacks(int playerAction, string Pname, int Phealth, int Pdamage, int enemyAction, string Ename, int Eheath, int Edamage)
        {
            //Setup
            Player player = new Player(Pname, Phealth, Pdamage);
            Enemy enemy = new Enemy(Ename, Eheath, Edamage);
            BattleFunc battleFunc = new BattleFunc();

            //Execute
            battleFunc.BattleSimulation(playerAction, enemyAction, player, enemy);

            //Assert
            Assert.AreEqual(enemy.MaxHp - player.Damage, enemy.CurrentHp);
        }

        //Testing player attack, enemy defend
        [TestMethod]
        [DataRow(1, "Elf", 50, 20, 2, "Rat", 50, 15, DisplayName = "Player Attack, Enemy Defend")]
        [DataRow(1, "Elf", 50, 1, 2, "Rat", 100, 15, DisplayName = "Player Attack, min damage")]
        [DataRow(1, "Elf", 50, 100, 2, "Rat", 1, 15, DisplayName = "Player Attack, max damage")]
        public void Test_BattleSim_Enemy_Defends(int playerAction, string Pname, int Phealth, int Pdamage, int enemyAction, string Ename, int Eheath, int Edamage)
        {
            //Setup
            Player player = new Player(Pname, Phealth, Pdamage);
            Enemy enemy = new Enemy(Ename, Eheath, Edamage);
            BattleFunc battleFunc = new BattleFunc();

            //Execute
            battleFunc.BattleSimulation(playerAction, enemyAction, player, enemy);

            //Assert
            Assert.AreEqual(enemy.MaxHp - (player.Damage * 0.8f), enemy.CurrentHp);
        }

        //Testing player attack, enemy heal
        [TestMethod]
        [DataRow(1, "Elf", 50, 15, 3, "Rat", 100, 15, DisplayName = "Player Attack, Enemy Heals")]
        [DataRow(1, "Elf", 1, 15, 3, "Rat", 100, 15, DisplayName = "Player Attack, Enemy Heals")]
        [DataRow(1, "Elf", 100, 15, 3, "Rat", 100, 15, DisplayName = "Player Attack, Enemy Heals")]
        public void Test_BattleSim_Enemy_Heals(int playerAction, string Pname, int Phealth, int Pdamage, int enemyAction, string Ename, int Eheath, int Edamage)
        {
            //Setup
            Player player = new Player(Pname, Phealth, Pdamage);
            Enemy enemy = new Enemy(Ename, Eheath, Edamage);
            BattleFunc battleFunc = new BattleFunc();

            //Expected result
            float expectedRemainingHealth = enemy.CurrentHp - player.Attack() + (enemy.MaxHp * 0.2f);
            if (enemy.MaxHp <= expectedRemainingHealth)
            {
                expectedRemainingHealth = enemy.MaxHp;
            }

            //Execute
            battleFunc.BattleSimulation(playerAction, enemyAction, player, enemy);

            //Assert
            Assert.AreEqual(expectedRemainingHealth, enemy.CurrentHp);
        }

        #endregion

        #region Player defends

        //Testing player defend, enemy attack
        [TestMethod]
        [DataRow(2, "Elf", 500, 15, 1, "Rat", 50, 10, DisplayName = "Player Defends")]
        [DataRow(2, "Elf", 1000, 15, 1, "Rat", 50, 10, DisplayName = "Player Defends maxHp")]
        [DataRow(2, "Elf", 1, 15, 1, "Rat", 50, 10, DisplayName = "Player Defends minHP")]
        public void Test_BattleSim_Player_Defends(int playerAction, string Pname, int Phealth, int Pdamage, int enemyAction, string Ename, int Eheath, int Edamage)
        {
            //Setup
            Player player = new Player(Pname, Phealth, Pdamage);
            Enemy enemy = new Enemy(Ename, Eheath, Edamage);
            BattleFunc battleFunc = new BattleFunc();

            //Execute
            battleFunc.BattleSimulation(playerAction, enemyAction, player, enemy);

            //Assert
            Assert.AreEqual(player.MaxHp - (enemy.Damage * 0.8), player.CurrentHp);
        }

        #endregion


        #region Player heals

        //Testing player heal, enemy attack
        [TestMethod]
        [DataRow(3, "Elf", 500, 15, 1, "Rat", 50, 10, DisplayName = "Player Heals")]
        [DataRow(3, "Elf", 1000, 15, 1, "Rat", 50, 10, DisplayName = "Player Heals maxHp")]
        [DataRow(3, "Elf", 1, 15, 1, "Rat", 50, 10, DisplayName = "Player Heals minHP")]
        public void Test_BattleSim_Player_Heals(int playerAction, string Pname, int Phealth, int Pdamage, int enemyAction, string Ename, int Eheath, int Edamage)
        {
            //Setup
            Player player = new Player(Pname, Phealth, Pdamage);
            Enemy enemy = new Enemy(Ename, Eheath, Edamage);
            BattleFunc battleFunc = new BattleFunc();

            //Expected result
            float expectedRemainingHealth = player.CurrentHp - enemy.Attack() + (player.MaxHp * 0.2f);
            if (player.MaxHp <= expectedRemainingHealth)
            {
                expectedRemainingHealth = player.MaxHp;
            }

            //Execute
            battleFunc.BattleSimulation(playerAction, enemyAction, player, enemy);

            //Assert
            Assert.AreEqual(expectedRemainingHealth, player.CurrentHp);
        }

        #endregion
    }

}
