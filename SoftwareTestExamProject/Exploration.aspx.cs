using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftwareTestExamProject
{
    public partial class Exploration : System.Web.UI.Page
    {
        private string mapString = "Label";
        private int mapSizeY = 4, mapSizeX = 4;
        Player player;

        protected void Page_Load(object sender, EventArgs e)
        {
            player = (Player)Session["player"];
            CreateMap();
            mapLabel.Text = mapString;
        }

        protected void ButtonUp_Click(object sender, EventArgs e)
        {
            if (player.coordinates[0] > 0)
            {
                player.coordinates[0] -= 1;
            }
            CreateMap();
            mapLabel.Text = mapString;
        }

        protected void ButtonDown_Click(object sender, EventArgs e)
        {
            if (player.coordinates[0] < mapSizeY - 1)
            {
                player.coordinates[0] += 1;
            }
            CreateMap();
            mapLabel.Text = mapString;
        }

        protected void ButtonLeft_Click(object sender, EventArgs e)
        {
            if (player.coordinates[1] > 0)
            {
                player.coordinates[1] -= 1;
            }

            CreateMap();
            mapLabel.Text = mapString;
        }

        protected void ButtonRight_Click(object sender, EventArgs e)
        {
            if (player.coordinates[1] < mapSizeX - 1)
            {
                player.coordinates[1] += 1;
            }

            CreateMap();
            mapLabel.Text = mapString;
        }

        private void CreateMap()
        {
            mapString = "";
            for (int x = 0; x < mapSizeX; x++)
            {
                for (int y = 0; y < mapSizeY; y++)
                {
                    // Tilføj antal rækker 
                    if (player.coordinates[0] == x && player.coordinates[1] == y)
                    {
                        mapString = mapString + "|_+_|";
                    }
                    else
                    {
                        mapString = mapString + "|___|";
                    }
                }
                mapString += "<br>";
            }

        }
    }
}