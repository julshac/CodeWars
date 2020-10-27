using System;

namespace Solutions
{
    public class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            var res = "";
            var hours = seconds / 3600;
            res += hours < 10 ? "0" + hours + ":" : hours + ":";
            var minutes = (seconds - (3600 * hours)) / 60;
            res += minutes < 10 ? "0" + minutes + ":" : minutes + ":";
            var sec = seconds - (3600 * hours) - (minutes * 60);
            res += sec < 10 ? "0" + sec : sec.ToString();
            return res;
        }
    }
}