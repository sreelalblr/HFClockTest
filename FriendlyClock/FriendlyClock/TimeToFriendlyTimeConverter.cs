using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyClock
{
    /// <summary>
    /// Class implementing logics to convert time into human friendly time format
    /// </summary>
    public class TimeToFriendlyTimeConverter : IFriendlyTimeConverter
    {
        private INumberToWordsConverter numberToWordsConverter;

        private DateTime timeToConvert;

        public TimeToFriendlyTimeConverter(INumberToWordsConverter numberToWordsConverter)
        {
            this.numberToWordsConverter = numberToWordsConverter;
        }

        public string GetHumanFriendlyTime(string inputTime)
        {
            if (DateTime.TryParse(inputTime, out timeToConvert))
            {
                var friendlyHour = new FriendlyHour(timeToConvert.Hour, timeToConvert.Minute, numberToWordsConverter);
                var friendlyMinute = new FriendlyMinute(timeToConvert.Minute, numberToWordsConverter);

                return TextUtility.CapitalizeFirstLetter($"{friendlyMinute.FriendlyTime} {friendlyHour.FriendlyTime}");
            }
            else
            {
                throw new ArgumentException("Invalid time format");
            }
        }
        
    }
}
