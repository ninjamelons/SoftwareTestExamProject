using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using SoftwareTestExamProject;

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

    public class Player : Character
    {
        
        public int[] coordinates = { 1, 1 };

        public Player(string name, int health, int damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public override void Attack()
        {

        }

        public override void Heal()
        {

        }

        public override void Defend()
        {

        }
    }

    public class Enemy : Character
    {
        public Enemy(string name, int health, int damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;

        }

        public override void Attack()
        {

        }

        public override void Heal()
        {

        }

        public override void Defend()
        {

        }
    }

    public class Inputs
    {
        public string NameInput(string input)
        {
            string result;

            /*
            ^ : start of string
            [ : beginning of character group
            a-z : any lowercase letter
            A-Z : any uppercase letter
            ÆØÅ : allow Æ Ø Å
            0-9 : any digit
            _ : underscore
            ] : end of character group
            * : zero or more of the given characters
            $ : end of string
            */
            var regexItem = new Regex("^[ÆØÅæøåa-zA-Z0-9]*$");

            if (input.Length < 40 && regexItem.IsMatch(input) == true && input.Length > 0)
            {
                result = input;
            }
            else
            {
                result = "-1";
            }

            return result;
        }

        public int HPInput(string input)
        {
            int result;

            if (Int32.TryParse(input, out int playerHP))
            {
                if (playerHP < 0 && playerHP > 1000)
                {
                    result = -1;
                }
                else
                {
                    result = playerHP;
                }
            }
            else
            {
                result = -1;
            }

            return result;
        }

        public int DMGInput(string input)
        {
            int result;
            if (Int32.TryParse(input, out int playerDMG))
            {
                if (playerDMG < 0 && playerDMG > 100)
                {
                    result = -1;
                }
                else
                {
                    result = playerDMG;
                }
            }
            else
            {
                result = -1;
            }
            return result;
        }
    }
}