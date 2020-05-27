using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoftwareTestExamProject.Functionality;

namespace SoftwareTestExamProject
{
    public class BattleFunc
    {
        readonly string[] enemyNames = { "Rat", "Dog", "Cat" };

        public Enemy CreateEnemy()
        {
            return new Enemy(RandomizeName(), RandomizeNumber(15, 150), RandomizeNumber(2, 20));
        }

        private int RandomizeNumber(int min, int max)
        {
            Random rnd = new Random();
            int rndizedInt = rnd.Next(min, max);

            return rndizedInt;
        }

        private string RandomizeName()
        {
            Random rnd = new Random();
            int rndName = rnd.Next(0, enemyNames.Length - 1);

            return enemyNames[rndName];
        }


        public int BattleSimulation(int playerAction, int enemyAction, Player player, Enemy enemy)
        {

            #region Do we defends?
            // Enemy
            if (enemyAction == 2)
            {
                enemy.Defend();
            }

            // Player
            if (playerAction == 2)
            {
                player.Defend();
            }
            #endregion

            #region Do we attack?
            // Enemy
            if (enemyAction == 1)
            {
                if (player.IsDefending)
                {
                    player.CurrentHp -= enemy.Attack() * 0.8f;
                }
                else
                {
                    player.CurrentHp -= enemy.Attack();
                }
            }

            // Player
            if (playerAction == 1)
            {
                if (enemy.IsDefending)
                {
                    enemy.CurrentHp -= player.Attack() * 0.8f;
                }
                else
                {
                    enemy.CurrentHp -= player.Attack();
                }
            }
            #endregion

            #region Do we heal?
            // Enemy 
            if (enemyAction == 3)
                enemy.Heal();

            //Player
            if (playerAction == 3)
                player.Heal();
            #endregion

            return enemyAction;
        }
    }
}