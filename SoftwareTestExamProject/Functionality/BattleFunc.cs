using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareTestExamProject
{
    public class BattleFunc
    {
        Player player;
        Enemy enemy;

        readonly string[] enemyNames = { "Rat", "Dog", "Cat" };

        public Enemy CreateEnemy()
        {
            enemy = new Enemy(RandomizeName(), RandomizeNumber(15, 150), RandomizeNumber(2, 20));
            return enemy;
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


        public void BattleSimulation(int playerAction)
        {
            Random rnd = new Random();
            int rndEnemyAction = rnd.Next(0, 3);

            if (rndEnemyAction == 2)
            {
                enemy.Defend();
            }
            switch (playerAction)
            {
                case 1:
                    player.Attack();
                    break;
                case 2:
                    player.Defend();
                    break;
                case 3:
                    player.Heal();
                    break;
                default:
                    //Error
                    break;
            }
            if (rndEnemyAction == 1)
            {
                enemy.Attack();
            }
            else
            {
                enemy.Heal();
            }
        }
    }
}