using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftwareTestExamProject.Functionality;

namespace SoftwareTestExamProject
{
    public partial class _Default : Page
    {
        private string nameInput = "-1";
        private int hpInput = -1;
        private int dmgInput = -1;
        Player player;
        Inputs input;

        protected void Page_Load(object sender, EventArgs e)
        {
            input = new Inputs();
        }

        protected void CreateCharacter_Click(object sender, EventArgs e)
        {
            player = new Player(nameInput, hpInput, dmgInput);

            Session["player"] = player;

            if (hpInput != -1 && dmgInput != -1 && nameInput != "-1")
            {
                //Redirect to the Exploration page
                Response.Redirect("~/Exploration.aspx");
            }
            else
            {
                ErrorLabel.Text = "";
                ErrorLabel.Text += "Please input a valid number for Health (1-1000)";
            }
        }

        protected void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameInput = input.NameInput(NameTextBox.Text);
        }

        protected void HPTextBox_TextChanged(object sender, EventArgs e)
        {
            int tmpPlayerHp = input.HPInput(HPTextBox.Text);

            hpInput = tmpPlayerHp;
        }

        protected void DMGTextBox_TextChanged(object sender, EventArgs e)
        {
            int tmpPlayerDmg = input.DMGInput(DMGTextBox.Text);

            if (tmpPlayerDmg == -1)
            {
                ErrorLabel.Text += "Please input a valid number (1-100). ";
            }
            else
            {
                dmgInput = tmpPlayerDmg;
            }
        }
    }
}