using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace SoftwareTestExamProject.Functionality
{
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