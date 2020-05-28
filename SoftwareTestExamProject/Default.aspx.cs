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
            ErrorLabel.Text = "";

            bool fail = false;

            if (nameInput == "-1")
            {
                ErrorLabel.Text += "Please input a valid Name (a-Å/numbers).<br>";
                fail = true;
            }
            if (hpInput == -1)
            {
                ErrorLabel.Text += "Please input a valid number for Health (1-1000).<br>";
                fail = true;
            }
            if (dmgInput == -1)
            {
                ErrorLabel.Text += "Please input a valid number for Damage (1-100).";
                fail = true;
            }

            if(!fail)
            {
                player = new Player(nameInput, hpInput, dmgInput);
                Session["player"] = player;

                //Redirect to the Exploration page
                Response.Redirect("~/Exploration.aspx");
            }
        }

        protected void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameInput = input.NameInput(NameTextBox.Text);
        }

        protected void HPTextBox_TextChanged(object sender, EventArgs e)
        {
            hpInput = input.HPInput(HPTextBox.Text);
        }

        protected void DMGTextBox_TextChanged(object sender, EventArgs e)
        {
            dmgInput = input.DMGInput(DMGTextBox.Text);
        }
    }
}