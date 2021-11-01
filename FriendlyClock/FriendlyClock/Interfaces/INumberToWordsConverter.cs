using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyClock
{
    /// <summary>
    /// Interface to convert number to number in words
    /// </summary>
    public interface INumberToWordsConverter
    {
        string ConvertNumberToWords(int number);
    }
}
