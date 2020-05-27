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


        public int  BattleSimulation(int playerAction, Player player, Enemy enemy)
        {
            Random rnd = new Random();
            int rndEnemyAction = rnd.Next(1, 3);

            //Enemy defend action
            if (rndEnemyAction == 2)
            {
                enemy.Defend();
            }
            switch (playerAction)
            {
                case 1:
                    if (enemy.IsDefending)
                    {
                        enemy.CurrentHp -= player.Attack() * 0.8f;
                        break;
                    }
                    enemy.CurrentHp -= player.Attack();

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

            //Enemy attack Action
            if (rndEnemyAction == 1)
            {
                if (player.IsDefending)
                {
                    player.CurrentHp -= enemy.Attack() * 0.8f;
                }
                else
                {
                    player.CurrentHp -= player.Attack();
                }
            }
            else
            {
                enemy.Heal();
            }
            return rndEnemyAction;
        }
    }
}