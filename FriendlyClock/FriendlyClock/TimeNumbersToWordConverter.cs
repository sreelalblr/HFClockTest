using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyClock
{
    /// <summary>
    /// Class that convert the range of numbers in a clock into words, it supports numbers from 1 to 59
    /// </summary>
    public class TimeNumbersToWordConverter : INumberToWordsConverter
    {
        readonly string errorNumberNotIntheRange;

        Dictionary<int, string> numberWordsLookUp;

        public TimeNumbersToWordConverter()
        {
            numberWordsLookUp = new Dictionary<int, string>();

            errorNumberNotIntheRange = "Input number is not in the range of 0 to 60";


            InitializeLookUp();
        }
        public string ConvertNumberToWords(int number)
        {
            if(number < 1 || number > 59)
            {
                throw new ArgumentOutOfRangeException(nameof(number),errorNumberNotIntheRange);
            }
                       

            string numberInWords = string.Empty;
                       

            if( number > 0 && number < 21)
            {
                numberInWords = numberWordsLookUp[number];
            }
            else
            {
                var remainder = number % 10;
                var tenthPlaceValue = number - remainder;

                if(remainder == 0)
                {
                    numberInWords = numberWordsLookUp[number];
                }
                else
                {
                    numberInWords = $"{ numberWordsLookUp[tenthPlaceValue]} {numberWordsLookUp[remainder]}";
                }
            }

            return numberInWords;
        }


        private void InitializeLookUp()
        {
            numberWordsLookUp.Add(1, "one");
            numberWordsLookUp.Add(2, "two");
            numberWordsLookUp.Add(3, "three");
            numberWordsLookUp.Add(4, "four");
            numberWordsLookUp.Add(5, "five");
            numberWordsLookUp.Add(6, "six");
            numberWordsLookUp.Add(7, "seven");
            numberWordsLookUp.Add(8, "eight");
            numberWordsLookUp.Add(9, "nine");

            numberWordsLookUp.Add(11, "eleven");
            numberWordsLookUp.Add(12, "twelve");
            numberWordsLookUp.Add(13, "thirteen");
            numberWordsLookUp.Add(14, "fourteen");
            numberWordsLookUp.Add(15, "fifteen");
            numberWordsLookUp.Add(16, "sixteen");
            numberWordsLookUp.Add(17, "seventeen");
            numberWordsLookUp.Add(18, "eighteen");
            numberWordsLookUp.Add(19, "nineteen");


            numberWordsLookUp.Add(10, "ten");
            numberWordsLookUp.Add(20, "twenty");
            numberWordsLookUp.Add(30, "thirty");
            numberWordsLookUp.Add(40, "forty");
            numberWordsLookUp.Add(50, "fifty");
            numberWordsLookUp.Add(60, "sixty");
        }
    }
}
