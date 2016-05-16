using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericalConversion.Class
{
    public class NumConvert
    {
        private const int MAX_CONVERT = 10000;
        // Create instance of Loopup class
        Lookup looktable = new Lookup();

        // Convert the numerical input into a verbal representation (string).
        public string convertInput(decimal input)
        {
            // Variables to contain the whole (dollar) and decimal (cents) of the input.
            var WhoNum = 0;
            var DecNum = 0;
            var output = "";
            // Bool to check if 'cents' needs to be returned.
            var iscent = false;
            var hasten = false;
            var onedol = false;
            var onecen = false;
            // Split the input into whole and decimal (dollars and cents) and store in WhoNum and DecNum.
            string split = input.ToString();
            string[] splitArray = split.Split('.');

            try
            {
                WhoNum = Int32.Parse(splitArray[0]);
                DecNum = Int32.Parse(splitArray[1]);
            }
            catch
            {

            }
            if (WhoNum == 1) { onedol = true; }
            if (DecNum == 1) { onecen = true; }

            // Call coresponding lookup function, depending on Whole number value, loop until the number reaches 0.
            if (WhoNum > MAX_CONVERT || WhoNum < 0 || DecNum < 0) { return ""; }
            while (WhoNum != 0)
            {
                if (WhoNum >= 1000 && WhoNum <= 10000)
                {
                    var kvp = looktable.getThousands(WhoNum);
                    output += kvp.Key;
                    WhoNum = kvp.Value;
                }
                else if (WhoNum >= 100 && WhoNum <= 999)
                {
                    var kvp = looktable.getHundreds(WhoNum);
                    output += kvp.Key;
                    WhoNum = kvp.Value;
                }
                else if (WhoNum >= 20 && WhoNum <= 99)
                {
                    // Add 'and ' to output when adding numbers from 'tens'.
                    if (output != "") { output += "and "; }
                    hasten = true;
                    var kvp = looktable.getTens(WhoNum);
                    output += kvp.Key;
                    WhoNum = kvp.Value;
                }
                else if (WhoNum >= 10 && WhoNum <= 19)
                {
                    // Add 'and ' to output when adding numbers from 'teens'.
                    if (output != "") { output += "and "; }

                    var kvp = looktable.getTeens(WhoNum);
                    output += kvp.Key;
                    WhoNum = kvp.Value;
                }
                else if (WhoNum >= 1 && WhoNum <= 9)
                {
                    // Add 'and ' to output when adding numbers from 'ones' if there are no tens.
                    if (output != "" && hasten == false) { output += "and "; }
                    var kvp = looktable.getOnes(WhoNum);
                    output += kvp.Key;
                    WhoNum = kvp.Value;
                }
            }

            // Add 'dollars ' to output when all dollar values have been converted.
            if (output != "")
            {
                if (onedol == true)
                {
                    output += "dollar ";
                }
                else
                {
                    output += "dollars ";
                }
            }
                // Add 'and ' to output when all dollar values have been converted and there is still cents to be converted.
                if (output != "" && DecNum != 0) { output += "and "; }

                // Call coresponding lookup function, depending on Decimal number value, loop until the number reaches 0.
                while (DecNum != 0)
                {
                    iscent = true;

                    if (DecNum >= 20 && DecNum <= 99)
                    {
                        var kvp = looktable.getTens(DecNum);
                        output += kvp.Key;
                        DecNum = kvp.Value;
                    }
                    else if (DecNum >= 10 && DecNum <= 19)
                    {
                        var kvp = looktable.getTeens(DecNum);
                        output += kvp.Key;
                        DecNum = kvp.Value;
                    }
                    else if (DecNum >= 1 && DecNum <= 9)
                    {
                        var kvp = looktable.getOnes(DecNum);
                        output += kvp.Key;
                        DecNum = kvp.Value;
                    }
                }
                // Add 'cents ' to output if cents have been converted'.
                if (iscent == true)
                {
                if (onecen == true)
                {
                    output += "cent";
                }
                else
                {
                    output += "cents";
                }
            }

                return output;
            }
        }
    }
