using System;
using System.Text.RegularExpressions;

namespace FriendlyClock
{
    class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                INumberToWordsConverter numberToWordsConverter = new TimeNumbersToWordConverter();

                IFriendlyTimeConverter friendlyTimeConverter = new TimeToFriendlyTimeConverter(numberToWordsConverter);

                string friendlyTime = string.Empty;

                if (args.Length > 0)
                {
                    friendlyTime = friendlyTimeConverter.GetHumanFriendlyTime(args[0]);
                }
                else
                {
                    friendlyTime = friendlyTimeConverter.GetHumanFriendlyTime(DateTime.Now.ToString());
                }

                Console.WriteLine(friendlyTime);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }             
        }
    }
        
}
