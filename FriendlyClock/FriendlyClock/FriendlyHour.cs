using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyClock
{
    /// <summary>
    /// Class makes the friendly hour component from given time
    /// </summary>
    internal class FriendlyHour: IFriendlyTimeComponent
    {
        private INumberToWordsConverter numberToWordsConverter;

        public FriendlyHour(int hour,int minute, INumberToWordsConverter numberToWordsConverter)
        {
            this.numberToWordsConverter = numberToWordsConverter;

            string suffix=  string.Empty;

            if(hour > 12)
            {
                hour = hour - 12;
            }

            if(minute > 30)
            {
                hour = hour + 1;
            }

            if(hour== 0)
            {
                hour = 12;
                suffix = "at night";
            }

            

            if (minute == 0)
            {
                FriendlyTime =  $"{numberToWordsConverter.ConvertNumberToWords(hour)} O' clock {suffix}";

            }
            else
            {
                FriendlyTime = $"{numberToWordsConverter.ConvertNumberToWords(hour)} {suffix}";

            }
        }

        public string FriendlyTime { get; set; }

    }
}
