using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public static class Solutions
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
        
        public static bool IsPangram(string str)
        {
            var alphabet = new List<char>()
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 
                'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };
            foreach (var n in str.Where(n => alphabet.Contains(char.ToUpper(n))))
                alphabet.Remove(char.ToUpper(n));
            return alphabet.Count == 0;
        }
        
        public static int CountingBits(int numb)
        {
            var bits = Convert.ToString(numb, 2);
            return bits.Count(n => n == '1');
        }
        
        public static string FirstNonRepeatingLetter(string s)
        {
            var letters = new Dictionary<char, int>();
            var res = ' ';
            var let = s.Select(t => char.ToUpper(t)).ToList();

            foreach (var letter in @let)
            {
                if (letters.Keys.Contains(letter))
                {
                    var tmp = letters[letter];
                    letters[letter] = tmp + 1;
                    continue;
                }
                letters.Add(letter, 1);
            }
            
            if (letters.Values.Contains(1)) res = letters.First(x => x.Value == 1).Key;

            foreach (var t in s.Where(t => t == res || t == res + 32 || t == res - 32))
                return Convert.ToString(t);
            return "";
        }

        public static int[] BubbleSort(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; ++i)
            {
                for (var j = i + 1; j < arr.Length; ++j)
                {
                    if (arr[i] <= arr[j]) continue;
                    var tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
            return arr;
        }
    }
}