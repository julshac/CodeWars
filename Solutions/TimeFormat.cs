using System;

namespace Solutions
{
    public class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            int hours, minutes, sec;
            string res = "";
            hours = seconds / 3600;
            if (hours < 10) res += "0" + hours + ":";
            else res += hours + ":";
            minutes = (seconds - (3600 * hours)) / 60;
            if (minutes < 10) res += "0" + minutes + ":";
            else res += minutes + ":";
            sec = seconds - (3600 * hours) - (minutes * 60);
            if (sec < 10) res += "0" + sec;
            else res += sec; 
            return res;
        }
    }
}