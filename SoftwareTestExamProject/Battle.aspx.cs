using SoftwareTestExamProject.Functionality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareTestExamProject
{
    public partial class Battle : System.Web.UI.Page
    {

        Player player;
        Enemy enemy;
        BattleFunc battleFunc;

        protected void Page_Load(object sender, EventArgs e)
        {
            battleFunc = new BattleFunc();
            player = (Player)Session["player"];

            if (Session["enemy"] == null)
            {
                Session["enemy"] = battleFunc.CreateEnemy();
            }
            enemy = (Enemy)Session["enemy"];

            LabelSetup();

        }


        protected void AttackButton_Click(object sender, EventArgs e)
        {
            UpdateLabels(1, battleFunc.BattleSimulation(1, new Random().Next(1, 4), player, enemy));
            HPCheck();
            ResetStates();
        }

        protected void DefendButton_Click(object sender, EventArgs e)
        {
            UpdateLabels(2, battleFunc.BattleSimulation(2, new Random().Next(1, 4), player, enemy));
            HPCheck();
            ResetStates();
        }

        protected void HealButton_Click(object sender, EventArgs e)
        {
            UpdateLabels(3, battleFunc.BattleSimulation(3, new Random().Next(1, 4), player, enemy));
            HPCheck();
            ResetStates();
        }

        private void ResetStates()
        {
            player.IsDefending = false;
            enemy.IsDefending = false;
        }

        private void LabelSetup()
        {
            playerNameLabel.Text = player.Name;
            playerHpLabel.Text = Convert.ToInt32(player.CurrentHp).ToString();
            playerDmgLabel.Text = Convert.ToInt32(player.Damage).ToString();

            enemyNameLabel.Text = enemy.Name;
            enemyHpLabel.Text = Convert.ToInt32(enemy.CurrentHp).ToString();
            enemyDmgLabel.Text = Convert.ToInt32(enemy.Damage).ToString();

            playerActionLabel.Text = "";
            enemyActionLabel.Text = "";
        }

        private void UpdateLabels(int playerAction, int enemyAction)
        {
            //Update enemy labels
            enemyHpLabel.Text = Convert.ToInt32(enemy.CurrentHp).ToString();
            enemyDmgLabel.Text = Convert.ToInt32(enemy.Damage).ToString();
            //Update player labels
            playerHpLabel.Text = Convert.ToInt32(player.CurrentHp).ToString();
            playerDmgLabel.Text = Convert.ToInt32(player.Damage).ToString();

            switch (playerAction)
            {
                case 1:
                    if (enemy.IsDefending)
                    {
                        playerActionLabel.Text = "Player Attacks and deals " + (player.Damage * 0.8f) + " damage";
                    }
                    else
                    {
                        playerActionLabel.Text = "Player Attacks and deals " + player.Damage + " damage";
                    }
                    break;
                case 2:
                    playerActionLabel.Text = "Player Defends";
                    break;
                case 3:
                    playerActionLabel.Text = "Player Heals";
                    break;
                default:
                    //Error
                    break;
            }

            switch (enemyAction)
            {
                case 1:
                    if (player.IsDefending)
                    {

                        enemyActionLabel.Text = "Enemy Attacks and deals " + (enemy.Damage * 0.8f) + " damage";
                    }
                    else
                    {
                        enemyActionLabel.Text = "Enemy Attacks and deals " + enemy.Damage + " damage";
                    }
                    break;
                case 2:
                    enemyActionLabel.Text = "Enemy Defends";
                    break;
                case 3:
                    enemyActionLabel.Text = "Enemy Heals";
                    break;
                default:
                    //Error
                    break;
            }
        }

        private void HPCheck()
        {
            if (player.CurrentHp <= 0)
            {
                Session.Clear();
                Response.Redirect("~/Default.aspx");
            }

            if (enemy.CurrentHp <= 0)
            {
                Session["enemy"] = battleFunc.CreateEnemy();

                Response.Redirect("~/Exploration.aspx");
            }
        }
    }
}