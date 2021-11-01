using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyClock
{
    /// <summary>
    /// Interface for converting time to human friendly time
    /// </summary>
    public interface IFriendlyTimeConverter
    {
        string GetHumanFriendlyTime(string inputTime);
    }
}
