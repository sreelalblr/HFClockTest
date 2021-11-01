using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyClock
{
    /// <summary>
    /// Helper class to convert a text into a text with capitalized 1st letter.
    /// </summary>
    internal class TextUtility
    {

        public static string CapitalizeFirstLetter(string text)
        {
            text = text.Trim();
            if (text.Length == 1)
                text = (text.ToUpper());
            else
                text = (char.ToUpper(text[0]) + text.Substring(1));

            return text;
        }
    }
}
