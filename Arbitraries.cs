using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Arbitraries
{


    class NumberGenerator
    {
        //THE LONGEST int NUMBER STORABLE IS 9,223,372,036,854,775,807
        private static string defaultSeed =
                   "314759265358979323846264338327950288409716939937510582097494459130781640628620899" +
                   "862803482534211706798217808651728230664709384460975058223172535940812848711745028" +
                   "410270193852110555964462294895493038796442881097566593374612847564823378678316527" +
                   "120190914574856691346034861075432664821339360716024917127372458700660631557817487" +
                   "152092096282925409171536436789259036001133053054882046652138414695197157160943305" +
                   "727036575979195";
        private string addedSeed;

        private bool usingDefaultSeed;

        private int size = 0;
        private int digitPosition = 17;


        public string ReadMe()
        {
            string readMeInformation =
                " This is the Random Number Generator created to output arbitrary numbers part of the namespace Arbitraries. \n" +
                " Using this library means that you are agreeing to the usage guides listed below :\n" +
                " I will will not modify, or exploit this library in any way. This will be for noncommercial use only unless\n" +
                " permission is granted through N2ition. The use of this library must be referenced and credited in your code\n" +
                " and end product.\n\n" +
                " Library usage : create a random number generator object using the default seed or by inputting a number string as\n" +
                " your own seed. \n\n To double check if this seed is usable before you commit it to an object, you can call the IsSeedBalanced()\n" +
                " method to return true or false.  Seed balance means all numbers in the string occur the same amount of times.\n\n" +
                " You can call SeedBalanceInfo() to check the occurence amount of each number 0-9 to see the occurence of it.\n\n ";
            return readMeInformation;
        }

        // public int getNextNumber() { };
        public NumberGenerator()
        {
            size = defaultSeed.Length;
            usingDefaultSeed = true;
        }

        public NumberGenerator(string stringSample)
        {
            addedSeed = stringSample;
            size = addedSeed.Length;
            usingDefaultSeed = false;
        }

        public char GetRandomNumberZeroToNine()
        {
            if (usingDefaultSeed)
            {
                if (digitPosition > size)
                {
                    digitPosition = 0;
                    return (defaultSeed[digitPosition]);
                }
                else
                {
                    digitPosition++;
                    return (defaultSeed[digitPosition - 1]);
                }
            }
            else
            {
                if (digitPosition > size)
                {
                    digitPosition = 0;
                    return (addedSeed[digitPosition]);
                }
                else
                {
                    digitPosition++;
                    return (addedSeed[digitPosition - 1]);
                }
            }
        }

        static public string SeedBalanceInfo(int groupingOfIntegers)
        {
            string stringOfNumbers = groupingOfIntegers.ToString();
            return SeedBalanceInfo(stringOfNumbers);
        }
        /* Takes in a string of numbers 0-9, checks and returns occurence of each value 
         * When adding a string of Numbers the number limit should be accounted for
         */
        static public string SeedBalanceInfo(string stringOfNumbers)
        {

            int zero = 0, one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0, nine = 0;

            foreach (char c in stringOfNumbers)
            {
                if (c == '0') { zero++; }
                else if (c == '1') { one++; }
                else if (c == '2') { two++; }
                else if (c == '3') { three++; }
                else if (c == '4') { four++; }
                else if (c == '5') { five++; }
                else if (c == '6') { six++; }
                else if (c == '7') { seven++; }
                else if (c == '8') { eight++; }
                else { nine++; }
            }

            return (" zero : " + zero + "\n one : " + one + "\n two : " + two + "\n three : " + three + "\n four : " + four + " \n five : " + five + " \n six : "
                + six + " \n seven :" + seven + " \n eight : " + eight + "\n nine : " + nine);
        }

        /* Checks argument list to see if it is balanced or not
         * When adding a string of Numbers the number limit should be accounted for 
         */
        public static bool IsSeedBalanced(string stringOfNumbers)
        {
            int zero = 0, one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0, nine = 0;

            foreach (char c in stringOfNumbers)
            {
                if (c == '0') { zero++; }
                else if (c == '1') { one++; }
                else if (c == '2') { two++; }
                else if (c == '3') { three++; }
                else if (c == '4') { four++; }
                else if (c == '5') { five++; }
                else if (c == '6') { six++; }
                else if (c == '7') { seven++; }
                else if (c == '8') { eight++; }
                else { nine++; }
            }

            LinkedList<int> listOfNumbers = new LinkedList<int>();
            listOfNumbers.AddFirst(zero); listOfNumbers.AddLast(one); listOfNumbers.AddLast(two); listOfNumbers.AddLast(three);
            listOfNumbers.AddLast(four); listOfNumbers.AddLast(five); listOfNumbers.AddLast(six); listOfNumbers.AddLast(seven);
            listOfNumbers.AddLast(eight); listOfNumbers.AddLast(nine);

            //cycle through list to find irregulaties
            for (int i = 0; i < 10; i++)
            {
                int previousValue = listOfNumbers.ElementAt(i);

                for (int j = i; j < 10; j++)
                {
                    int nextValue = listOfNumbers.ElementAt(j);
                    if (listOfNumbers.ElementAt(j) != listOfNumbers.ElementAt(i)) { return false; }
                }
            }
            return true;
        }
    }


}
