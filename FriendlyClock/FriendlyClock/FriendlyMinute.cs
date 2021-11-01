using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyClock
{
    /// <summary>
    /// Class makes the friendly minute component from given time
    /// </summary>
    internal class FriendlyMinute : IFriendlyTimeComponent
    {
        const string Past = "past";
        const string To = "to";
        const string QuarterTo = "quarter to";
        const string QuarterPast = "quarter past";
        const string HalfPast = "half past";

        INumberToWordsConverter numberToWordsConverter;

        public FriendlyMinute(int minute, INumberToWordsConverter numberToWordsConverter)
        {
            this.numberToWordsConverter = numberToWordsConverter;

            if (minute == 0)
                FriendlyTime = String.Empty;

            else if (minute == 15)
                FriendlyTime = QuarterPast;

            else if (minute == 30)
                FriendlyTime = HalfPast;

            else if (minute == 45)
                FriendlyTime = QuarterTo;

            else if (minute < 30)
                FriendlyTime = $"{numberToWordsConverter.ConvertNumberToWords(minute)} {Past}";

            else
                FriendlyTime = $"{numberToWordsConverter.ConvertNumberToWords(60 - minute)} {To}";

        }

        public string FriendlyTime { get; set; }

    }
}
