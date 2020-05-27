﻿using SoftwareTestExamProject.Functionality;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareTestExamProject
{
    public partial class Exploration : System.Web.UI.Page
    {
        Player player;
       public ExplorationFunc exp;

        protected void Page_Load(object sender, EventArgs e)
        {
            player = (Player)Session["player"];
            exp = new ExplorationFunc(4, 4);
            mapLabel.Text = exp.CreateMap(player.coordinates);
        }

        protected void ButtonUp_Click(object sender, EventArgs e)
        {
            player.coordinates = exp.ButtonUp_Click(player.coordinates);
            mapLabel.Text = exp.CreateMap(player.coordinates);
            Encounter();
        }

        protected void ButtonDown_Click(object sender, EventArgs e)
        {
            player.coordinates = exp.ButtonDown_Click(player.coordinates);
            mapLabel.Text = exp.CreateMap(player.coordinates);
            Encounter();
        }

        protected void ButtonLeft_Click(object sender, EventArgs e)
        {
            player.coordinates = exp.ButtonLeft_Click(player.coordinates);
            mapLabel.Text = exp.CreateMap(player.coordinates);
            Encounter();
        }

        protected void ButtonRight_Click(object sender, EventArgs e)
        {
            player.coordinates = exp.ButtonRight_Click(player.coordinates);
            mapLabel.Text = exp.CreateMap(player.coordinates);
            Encounter();
        }

        private void Encounter()
        {
            Random rnd = new Random();
            int tmpRnd = rnd.Next(0, 5);

            if (tmpRnd <= 2)
            {
                Response.Redirect("~/Battle.aspx");
            }
        }
    }
}