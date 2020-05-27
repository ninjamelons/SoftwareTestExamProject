using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareTestExamProject
{
    public class Test
    {
        private int mapSizeX;
        private int mapSizeY;

        public Test(int mapsizeX, int mapsizeY)
        {
            this.mapSizeX = mapsizeX;
            this.mapSizeY = mapsizeY;
        }

        public int[] ButtonUp_Click(int[] playerCoords)
        {
            if (playerCoords[1] > 0)
            {
                playerCoords[1] -= 1;
            }
            return playerCoords;
        }

        public int[] ButtonDown_Click(int[] playerCoords)
        {
            if (playerCoords[1] < mapSizeY - 1)
            {
                playerCoords[1] += 1;
            }
            return playerCoords;
        }

        public int[] ButtonLeft_Click(int[] playerCoords)
        {
            if (playerCoords[0] > 0)
            {
                playerCoords[0] -= 1;
            }
            return playerCoords;
        }

        public int[] ButtonRight_Click(int[] playerCoords)
        {
            if (playerCoords[0] < mapSizeX - 1)
            {
                playerCoords[0] += 1;
            }
            return playerCoords;
        }

        public string CreateMap(int[] playerCoords)
        {
            string mapString = "";

            for (int y = 0; y < mapSizeY; y++)
            {
                for (int x = 0; x < mapSizeX; x++)
                {
                    // Tilføj antal rækker 
                    if (playerCoords[0] == x && playerCoords[1] == y)
                    {
                        mapString += "|_+_|";
                    }
                    else
                    {
                        mapString += "|___|";
                    }
                }
                mapString += "<br>";
            }

            return mapString;
        }
    }
}