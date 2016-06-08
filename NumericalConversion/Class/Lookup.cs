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
        public KeyValuePair<String, int> getHundredsMillions(int input)
        {
            if (input >= 100000000 && input <= 199999999)
            {

                return new KeyValuePair<string, int>("One Hundred ", (input - 100000000));
            }
            else if (input >= 200000000 && input <= 299999999)
            {

                return new KeyValuePair<string, int>("Two Hundred ", (input - 200000000));
            }
            else if (input >= 300000000 && input <= 399999999)
            {

                return new KeyValuePair<string, int>("Three Hundred ", (input - 300000000));
            }
            else if (input >= 400000000 && input <= 499999999)
            {

                return new KeyValuePair<string, int>("Four Hundred ", (input - 400000000));
            }
            else if (input >= 500000000 && input <= 599999999)
            {

                return new KeyValuePair<string, int>("Five Hundred ", (input - 500000000));
            }
            else if (input >= 600000000 && input <= 699999999)
            {

                return new KeyValuePair<string, int>("Six Hundred ", (input - 600000000));
            }
            else if (input >= 70000000 && input <= 799999999)
            {

                return new KeyValuePair<string, int>("Seven Hundred ", (input - 700000000));
            }
            else if (input >= 800000000 && input <= 899999999)
            {

                return new KeyValuePair<string, int>("Eight Hundred ", (input - 800000000));
            }
            else if (input >= 900000000 && input <= 999999999)
            {

                return new KeyValuePair<string, int>("Nine Hundred ", (input - 900000000));
            }


            return new KeyValuePair<string, int>("", input); ;

        }

        // Function to return the String of converted number, aswell as the new number to be converted.
        // For numbers in the 'thousands' column
        public KeyValuePair<String, int> getTensMillions(int input)
        {

            if (input >= 20000000 && input <= 29999999)
            {

                return new KeyValuePair<string, int>("Twenty ", (input - 20000000));
            }
            else if (input >= 30000000 && input <= 39999999)
            {

                return new KeyValuePair<string, int>("Thirty ", (input - 30000000));
            }
            else if (input >= 40000000 && input <= 49999999)
            {

                return new KeyValuePair<string, int>("Forty ", (input - 40000000));
            }
            else if (input >= 50000000 && input <= 59999999)
            {

                return new KeyValuePair<string, int>("Fifty ", (input - 50000000));
            }
            else if (input >= 60000000 && input <= 69999999)
            {

                return new KeyValuePair<string, int>("Sixty ", (input - 60000000));
            }
            else if (input >= 70000000 && input <= 79999999)
            {

                return new KeyValuePair<string, int>("Seventy ", (input - 70000000));
            }
            else if (input >= 80000000 && input <= 89999999)
            {

                return new KeyValuePair<string, int>("Eighty ", (input - 80000000));
            }
            else if (input >= 90000000 && input <= 99999999)
            {

                return new KeyValuePair<string, int>("Ninty ", (input - 90000000));
            }


            return new KeyValuePair<string, int>("", input); ;

        }

        // Function to return the String of converted number, aswell as the new number to be converted.
        // For numbers in the 'thousands' column
        public KeyValuePair<String, int> getTeenMillions(int input)
        {

            if (input >= 10000000 && input <= 10999999)
            {

                return new KeyValuePair<string, int>("Ten Million ", (input - 10000000));
            }
            else if (input >= 11000000 && input <= 11999999)
            {

                return new KeyValuePair<string, int>("Eleven Million ", (input - 11000000));
            }
            else if (input >= 12000000 && input <= 12999999)
            {

                return new KeyValuePair<string, int>("Twelve Million ", (input - 12000000));
            }
            else if (input >= 13000000 && input <= 13999999)
            {

                return new KeyValuePair<string, int>("Thirteen Million ", (input - 13000000));
            }
            else if (input >= 14000000 && input <= 14999999)
            {

                return new KeyValuePair<string, int>("Fourteen Million ", (input - 14000000));
            }
            else if (input >= 15000000 && input <= 15999999)
            {

                return new KeyValuePair<string, int>("Fifteen Million ", (input - 15000000));
            }
            else if (input >= 16000000 && input <= 16999999)
            {

                return new KeyValuePair<string, int>("Sixteen Million ", (input - 16000000));
            }
            else if (input >= 17000000 && input <= 17999999)
            {

                return new KeyValuePair<string, int>("Seventeen Million ", (input - 17000000));
            }
            else if (input >= 18000000 && input <= 18999999)
            {

                return new KeyValuePair<string, int>("Eighteen Million ", (input - 18000000));
            }
            else if (input >= 19000000 && input <= 19999999)
            {

                return new KeyValuePair<string, int>("Ninteen Million ", (input - 19000000));
            }


            return new KeyValuePair<string, int>("", input); ;

        }

        // Function to return the String of converted number, aswell as the new number to be converted.
        // For numbers in the 'thousands' column
        public KeyValuePair<String, int> getMillions(int input)
        {

            if (input >= 1000000 && input <= 1999999)
            {

                return new KeyValuePair<string, int>("One Million ", (input - 1000000));
            }
            else if (input >= 2000000 && input <= 2999999)
            {

                return new KeyValuePair<string, int>("Two Million ", (input - 2000000));
            }
            else if (input >= 3000000 && input <= 3999999)
            {

                return new KeyValuePair<string, int>("Three Million ", (input - 3000000));
            }
            else if (input >= 4000000 && input <= 4999999)
            {

                return new KeyValuePair<string, int>("Four Million ", (input - 4000000));
            }
            else if (input >= 5000000 && input <= 5999999)
            {

                return new KeyValuePair<string, int>("Five Million ", (input - 5000000));
            }
            else if (input >= 6000000 && input <= 6999999)
            {

                return new KeyValuePair<string, int>("Six Million ", (input - 6000000));
            }
            else if (input >= 7000000 && input <= 7999999)
            {

                return new KeyValuePair<string, int>("Seven Million ", (input - 7000000));
            }
            else if (input >= 8000000 && input <= 8999999)
            {

                return new KeyValuePair<string, int>("Eight Million ", (input - 8000000));
            }
            else if (input >= 9000000 && input <= 9999999)
            {

                return new KeyValuePair<string, int>("Nine Million ", (input - 9000000));
            }


            return new KeyValuePair<string, int>("", input); ;

        }

        // Function to return the String of converted number, aswell as the new number to be converted.
        // For numbers in the 'thousands' column
        public KeyValuePair<String, int> getHundredsThousands(int input)
        {

            if (input >= 100000 && input <= 199999)
            {

                return new KeyValuePair<string, int>("One Hundred ", (input - 100000));
            }
            else if (input >= 200000 && input <= 299999)
            {

                return new KeyValuePair<string, int>("Two Hundred ", (input - 200000));
            }
            else if (input >= 300000 && input <= 399999)
            {

                return new KeyValuePair<string, int>("Three Hundred ", (input - 300000));
            }
            else if (input >= 400000 && input <= 499999)
            {

                return new KeyValuePair<string, int>("Four Hundred ", (input - 400000));
            }
            else if (input >= 500000 && input <= 599999)
            {

                return new KeyValuePair<string, int>("Five Hundred ", (input - 500000));
            }
            else if (input >= 600000 && input <= 699999)
            {

                return new KeyValuePair<string, int>("Six Hundred ", (input - 600000));
            }
            else if (input >= 700000 && input <= 799999)
            {

                return new KeyValuePair<string, int>("Seven Hundred ", (input - 700000));
            }
            else if (input >= 800000 && input <= 899999)
            {

                return new KeyValuePair<string, int>("Eight Hundred ", (input - 800000));
            }
            else if (input >= 900000 && input <= 999999)
            {

                return new KeyValuePair<string, int>("Nine Hundred ", (input - 900000));
            }


            return new KeyValuePair<string, int>("", input); ;

        }
        // Function to return the String of converted number, aswell as the new number to be converted.
        // For numbers in the 'thousands' column
        public KeyValuePair<String, int> getTensThousands(int input)
        {

            if (input >= 20000 && input <= 29999)
            {

                return new KeyValuePair<string, int>("Twenty ", (input - 20000));
            }
            else if (input >= 30000 && input <= 39999)
            {

                return new KeyValuePair<string, int>("Thirty ", (input - 30000));
            }
            else if (input >= 40000 && input <= 49999)
            {

                return new KeyValuePair<string, int>("Forty ", (input - 40000));
            }
            else if (input >= 50000 && input <= 59999)
            {

                return new KeyValuePair<string, int>("Fifty ", (input - 50000));
            }
            else if (input >= 60000 && input <= 69999)
            {

                return new KeyValuePair<string, int>("Sixty ", (input - 60000));
            }
            else if (input >= 70000 && input <= 79999)
            {

                return new KeyValuePair<string, int>("Seventy ", (input - 70000));
            }
            else if (input >= 80000 && input <= 89999)
            {

                return new KeyValuePair<string, int>("Eighty ", (input - 80000));
            }
            else if (input >= 90000 && input <= 99999)
            {

                return new KeyValuePair<string, int>("Ninty ", (input - 90000));
            }


            return new KeyValuePair<string, int>("", input); ;

        }

        // Function to return the String of converted number, aswell as the new number to be converted.
        // For numbers in the 'thousands' column
        public KeyValuePair<String, int> getTeenThousands(int input)
        {

            if (input >= 10000 && input <= 10999)
            {
                return new KeyValuePair<string, int>("Ten Thousand ", (input - 10000));

            }
            else if (input >= 11000 && input <= 11999)
            {

                return new KeyValuePair<string, int>("Eleven Thousand ", (input - 11000));
            }
            else if (input >= 12000 && input <= 12999)
            {

                return new KeyValuePair<string, int>("Twelve Thousand ", (input - 12000));
            }
            else if (input >= 13000 && input <= 13999)
            {

                return new KeyValuePair<string, int>("Thirteen Thousand ", (input - 13000));
            }
            else if (input >= 14000 && input <= 14999)
            {

                return new KeyValuePair<string, int>("Fourteen Thousand ", (input - 14000));
            }
            else if (input >= 15000 && input <= 15999)
            {

                return new KeyValuePair<string, int>("Fifteen Thousand ", (input - 15000));
            }
            else if (input >= 16000 && input <= 16999)
            {

                return new KeyValuePair<string, int>("Sixteen Thousand ", (input - 16000));
            }
            else if (input >= 17000 && input <= 17999)
            {

                return new KeyValuePair<string, int>("Seventeen Thousand ", (input - 17000));
            }
            else if (input >= 18000 && input <= 18999)
            {

                return new KeyValuePair<string, int>("Eighteen Thousand ", (input - 18000));
            }
            else if (input >= 19000 && input <= 19999)
            {

                return new KeyValuePair<string, int>("Ninteen Thousand ", (input - 19000));
            }
         


            return new KeyValuePair<string, int>("", input); ;

        }

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

                return new KeyValuePair<string, int>("Twenty", (input - 20));
            }
            else if (input >= 30 && input <= 39)
            {

                return new KeyValuePair<string, int>("Thirty", (input - 30));
            }
            else if (input >= 40 && input <= 49)
            {

                return new KeyValuePair<string, int>("Forty", (input - 40));
            }
            else if (input >= 50 && input <= 59)
            {

                return new KeyValuePair<string, int>("Fifty", (input - 50));
            }
            else if (input >= 60 && input <= 69)
            {

                return new KeyValuePair<string, int>("Sixty", (input - 60));
            }
            else if (input >= 70 && input <= 79)
            {

                return new KeyValuePair<string, int>("Seventy", (input - 70));
            }
            else if (input >= 80 && input <= 89)
            {

                return new KeyValuePair<string, int>("Eighty", (input - 80));
            }
            else if (input >= 90 && input <= 99)
            {

                return new KeyValuePair<string, int>("Ninety", (input - 90));
            }

            return new KeyValuePair<string, int>("", input);


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