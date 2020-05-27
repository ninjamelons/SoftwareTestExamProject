using SoftwareTestExamProject;
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

        //Label names:  playerNameLabel, playerHpLabel, playerDmgLabel, 
        //              enemyDmgLabel, enemyDmgLabel, enemyDmgLabel
        Player player;
        Enemy enemy;
        BattleFunc battleFunc;

        protected void Page_Load(object sender, EventArgs e)
        {
            battleFunc = new BattleFunc();
            player = (Player)Session["player"];
            battleFunc.CreateEnemy();
        }

 
        protected void AttackButton_Click(object sender, EventArgs e)
        {
            battleFunc.BattleSimulation(1);
        }

        protected void DefendButton_Click(object sender, EventArgs e)
        {
            battleFunc.BattleSimulation(2);
        }

        protected void HealButton_Click(object sender, EventArgs e)
        {
            battleFunc.BattleSimulation(3);
        }
    }
}