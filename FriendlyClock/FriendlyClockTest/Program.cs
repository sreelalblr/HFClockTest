using System;
using System.Diagnostics;

namespace FriendlyClockTest
{
    public class Program
    {
        static void  Main(string[] args)
        {
            Console.WriteLine("output from Friendly Clock :");
            Console.WriteLine("==============================");
            //var fileName = @"E:\Sree\Coding\interview\FriendlyClock\FriendlyClock\bin\Debug\netcoreapp3.1\FriendlyClock.exe";

            var fileName = @"..\..\..\..\FriendlyClock\bin\Debug\netcoreapp3.1\FriendlyClock.exe";
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = fileName;
            

            DisplayFriendlyTime(p, "10:30");
            DisplayFriendlyTime(p, "11:15");
            DisplayFriendlyTime(p, "10:40");
            DisplayFriendlyTime(p, "9:30");
            DisplayFriendlyTime(p, "09:30");
            DisplayFriendlyTime(p, "11:31");
            DisplayFriendlyTime(p, "11:15");
            DisplayFriendlyTime(p, "11:45");
            DisplayFriendlyTime(p, "11:40");
            DisplayFriendlyTime(p, "12:0");
            DisplayFriendlyTime(p, "12:00");
            DisplayFriendlyTime(p, "22:59");
            DisplayFriendlyTime(p, "23:45");
            DisplayFriendlyTime(p, "22:60");
            DisplayFriendlyTime(p, "00:00");
            DisplayFriendlyTime(p, "24:00");
            DisplayFriendlyTime(p, "00:10");
            DisplayFriendlyTime(p, "05660:5454");
            DisplayFriendlyTime(p, "20:61");
            DisplayFriendlyTime(p, "25:61");
            DisplayFriendlyTime(p, "25fdff61");
            DisplayFriendlyTime(p, "12/15");
            DisplayFriendlyTime(p, "12,15");


            return;
        }

        static void DisplayFriendlyTime(Process p, string time)
        {
            string output;
            p.StartInfo.ArgumentList.Clear();
            p.StartInfo.ArgumentList.Add(time);
            p.Start();
            output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            Console.WriteLine($"Time: {time}  FriendlyTime: {output}");
        }
    }
}
