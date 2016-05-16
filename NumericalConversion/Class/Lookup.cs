using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericalConversion.Class
{
    // This class provides a Lookup for a corresponding verbal representation of a number.
    public class Lookup
    {
        // Function to return the String of converted number, aswell as the new number to be converted.
        // For numbers in the 'thousands' column
        public KeyValuePair<String, int> getThousands(int input)
        {

            if (input >= 1000 && input <= 1999)
            {
                return new KeyValuePair<string, int>("One Thousand ", (input - 1000));

            }
            else if (input >= 2000 && input <= 2999)
            {

                return new KeyValuePair<string, int>("Two Thousand ", (input - 2000));
            }
            else if (input >= 3000 && input <= 3999)
            {

                return new KeyValuePair<string, int>("Three Thousand ", (input - 3000));
            }
            else if (input >= 4000 && input <= 4999)
            {

                return new KeyValuePair<string, int>("Four Thousand ", (input - 4000));
            }
            else if (input >= 5000 && input <= 5999)
            {

                return new KeyValuePair<string, int>("Five Thousand ", (input - 5000));
            }
            else if (input >= 6000 && input <= 6999)
            {

                return new KeyValuePair<string, int>("Six Thousand ", (input - 6000));
            }
            else if (input >= 7000 && input <= 7999)
            {

                return new KeyValuePair<string, int>("Seven Thousand ", (input - 7000));
            }
            else if (input >= 8000 && input <= 8999)
            {

                return new KeyValuePair<string, int>("Eight Thousand ", (input - 8000));
            }
            else if (input >= 9000 && input <= 9999)
            {

                return new KeyValuePair<string, int>("Nine Thousand ", (input - 9000));
            }
            else if (input == 10000)
            {

                return new KeyValuePair<string, int>("Ten Thousand ", (input - 10000));
            }


            return new KeyValuePair<string, int>("", input); ;

        }

        // Function to return the String of converted number, aswell as the new number to be converted.
        // For numbers in the 'hundreds' column
        public KeyValuePair<String, int> getHundreds(int input)
        {

            if (input >= 100 && input <= 199)
            {

                return new KeyValuePair<string, int>("One Hundred ", (input - 100));

            }
            else if (input >= 200 && input <= 299)
            {

                return new KeyValuePair<string, int>("Two Hundred ", (input - 200));
            }
            else if (input >= 300 && input <= 399)
            {

                return new KeyValuePair<string, int>("Three Hundred ", (input - 300));
            }
            else if (input >= 400 && input <= 499)
            {

                return new KeyValuePair<string, int>("Four Hundred ", (input - 400));
            }
            else if (input >= 500 && input <= 599)
            {

                return new KeyValuePair<string, int>("Five Hundred ", (input - 500));
            }
            else if (input >= 600 && input <= 699)
            {

                return new KeyValuePair<string, int>("Six Hundred ", (input - 600));
            }
            else if (input >= 700 && input <= 799)
            {

                return new KeyValuePair<string, int>("Seven Hundred ", (input - 700));
            }
            else if (input >= 800 && input <= 899)
            {

                return new KeyValuePair<string, int>("Eight Hundred ", (input - 800));
            }
            else if (input >= 900 && input <= 999)
            {

                return new KeyValuePair<string, int>("Nine Hundred ", (input - 900));
            }


            return new KeyValuePair<string, int>("", input); ;

        }

        // Function to return the String of converted number, aswell as the new number to be converted.
        // For numbers in the 'tens' column
        public KeyValuePair<String, int> getTens(int input)
        {
            if (input >= 20 && input <= 29)
            {

                return new KeyValuePair<string, int>("Twenty ", (input - 20));
            }
            else if (input >= 30 && input <= 39)
            {

                return new KeyValuePair<string, int>("Thirty ", (input - 30));
            }
            else if (input >= 40 && input <= 49)
            {

                return new KeyValuePair<string, int>("Forty ", (input - 40));
            }
            else if (input >= 50 && input <= 59)
            {

                return new KeyValuePair<string, int>("Fifty ", (input - 50));
            }
            else if (input >= 60 && input <= 69)
            {

                return new KeyValuePair<string, int>("Sixty ", (input - 60));
            }
            else if (input >= 70 && input <= 79)
            {

                return new KeyValuePair<string, int>("Seventy ", (input - 70));
            }
            else if (input >= 80 && input <= 89)
            {

                return new KeyValuePair<string, int>("Eighty ", (input - 80));
            }
            else if (input >= 90 && input <= 99)
            {

                return new KeyValuePair<string, int>("Ninety ", (input - 90));
            }


            return new KeyValuePair<string, int>("", input); ;

        }


        // Function to return the String of converted number, aswell as the new number to be converted.
        // For numbers in the 'teens' column
        public KeyValuePair<String, int> getTeens(int input)
        {

            if (input == 10)
            {

                return new KeyValuePair<string, int>("Ten ", (input - 10));

            }
            else if (input == 11)
            {

                return new KeyValuePair<string, int>("Eleven ", (input - 11));
            }
            else if (input == 12)
            {

                return new KeyValuePair<string, int>("Twelve ", (input - 12));
            }
            else if (input == 13)
            {

                return new KeyValuePair<string, int>("Thirteen ", (input - 13));
            }
            else if (input == 14)
            {

                return new KeyValuePair<string, int>("Fourteen ", (input - 14));
            }
            else if (input == 15)
            {

                return new KeyValuePair<string, int>("Fifteen ", (input - 15));
            }
            else if (input == 16)
            {

                return new KeyValuePair<string, int>("Sixteen ", (input - 16));
            }
            else if (input == 17)
            {

                return new KeyValuePair<string, int>("Seventeen ", (input - 17));
            }
            else if (input == 18)
            {

                return new KeyValuePair<string, int>("Eighteen ", (input - 18));
            }
            else if (input == 19)
            {

                return new KeyValuePair<string, int>("Nineteen ", (input - 19));
            }


            return new KeyValuePair<string, int>("", input); ;

        }

        // Function to return the String of converted number, aswell as the new number to be converted.
        // For numbers in the 'ones' column
        public KeyValuePair<String, int> getOnes(int input)
        {

            if (input == 1)
            {

                return new KeyValuePair<string, int>("One ", (input - 1));

            }
            else if (input == 2)
            {

                return new KeyValuePair<string, int>("Two ", (input - 2));
            }
            else if (input == 3)
            {

                return new KeyValuePair<string, int>("Three ", (input - 3));
            }
            else if (input == 4)
            {

                return new KeyValuePair<string, int>("Four ", (input - 4));
            }
            else if (input == 5)
            {

                return new KeyValuePair<string, int>("Five ", (input - 5));
            }
            else if (input == 6)
            {

                return new KeyValuePair<string, int>("Six ", (input - 6));
            }
            else if (input == 7)
            {

                return new KeyValuePair<string, int>("Seven ", (input - 7));
            }
            else if (input == 8)
            {

                return new KeyValuePair<string, int>("Eight ", (input - 8));
            }
            else if (input == 9)
            {

                return new KeyValuePair<string, int>("Nine ", (input - 9));
            }


            return new KeyValuePair<string, int>("", input); ;

        }
    }
}