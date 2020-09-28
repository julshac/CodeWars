using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public class Solutions
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
        
        public static bool IsPangram(string str)
        {
            List<char> alphabet = new List<char>()
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 
                'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };
            foreach(var n in str)
            {
                if (alphabet.Contains(char.ToUpper(n))) alphabet.Remove(char.ToUpper(n));
            }
            return alphabet.Count == 0;
        }
        
        public static int CountingBits(int numb)
        {
            string bits = Convert.ToString(numb, 2);
            return bits.Count(n => n == '1');
        }
        
        public static string FirstNonRepeatingLetter(string s)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            int tmp = 0;
            char res = ' ';
            List<char> let = new List<char>();
            
            foreach (char t in s) let.Add(char.ToUpper(t));
            
            for (int i = 0; i < let.Count; ++i)
            {
                if (letters.Keys.Contains(let[i]))
                {
                    tmp = letters[let[i]];
                    letters[let[i]] = tmp + 1;
                    continue;
                }
                letters.Add(let[i], 1);
            }
            
            if (letters.Values.Contains(1)) res = letters.First(x => x.Value == 1).Key;

            foreach (var t in s)
            {
                if (t == res || t == res + 32 || t == res - 32) return Convert.ToString(t);
            }
            return "";
        }

        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                for (int j = i + 1; j < arr.Length; ++j)
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            return arr;
        }
    }
}