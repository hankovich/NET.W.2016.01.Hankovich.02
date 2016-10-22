using System;
using System.Text;

namespace Logic
{
    public static class Tasks
    {
        /// <summary>
        /// Find index of element in array with equal right and left sums
        /// </summary>
        /// <param name="array">Array to find index in</param>
        /// <returns>Index of such element(if it exists), otherwise, -1</returns>
        public static int FindArrayCenter(int[] array)
        {
            int leftSum = 0, rightSum = 0;
            for (int i = 1; i < array.Length; i++)
                rightSum += array[i];
            for (int i = 1; i < array.Length; i++)
            {
                leftSum += array[i - 1];
                rightSum -= array[i];
                if (leftSum == rightSum)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Find concatenated sorted alphabetically string, w/o recurring characters.  
        /// Asymptotic behavior O(1), but input strings consist of 'a'-'z' only
        /// </summary>
        /// <param name="a">First string</param>
        /// <param name="b">Second string</param>
        /// <returns>Concatenation result</returns>
        public static string SimpleLexicographicalConcatination(string a, string b)
        {
            StringBuilder str = new StringBuilder();
            for (char i = 'a'; i < 'z' + 1; i++)
            {
                if (a.Contains(i.ToString()) || b.Contains(i.ToString()))
                    str.Append(i.ToString());
            }
            return str.ToString();
        }

        /// <summary>
        /// Find concatenated sorted alphabetically string, w/o recurring characters.  
        /// Asymptotic behavior O(n + m), where n and m - lengths of parameters. Use this method for any strings.
        /// </summary>
        /// <param name="a">First string</param>
        /// <param name="b">Second string</param>
        /// <returns>Concatenation result</returns>
        public static string LexicographicalConcatination(string a, string b)
        {
            StringBuilder str = new StringBuilder();
            StringBuilder result = new StringBuilder();
            char[] chars = str.Append(a).Append(b).ToString().ToCharArray();

            Array.Sort(chars);
            for (int i = 0; i < chars.Length; i++)
            {
                if (i == 0 || chars[i - 1] != chars[i])
                    result.Append(chars[i].ToString());
            }
            return result.ToString();
        }

        /// <summary>
        /// Insert second number to the first number, the second number takes position for j to i.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="i">Position to finish inserting</param>
        /// <param name="j">Position to start inserting</param>
        /// <returns>Inserting result</returns>
        public static int BinaryInsertion(int a, int b, int i, int j)
        {
            int length = (b >= 0) ? (int)Math.Floor(Math.Log(b) / Math.Log(2)) + 1 : 32;
            int mask = ~(((int)Math.Pow(2, j - i + 1) - 1) << i);
            int na = a & mask;
            length = length - (j - i + 1);
            if (length < 0)
                length = 0;
            int nb = b >> length;
            nb = nb & ((int)Math.Pow(2, 32 - length) - 1);
            nb = nb << i;
            return (na | nb);
        }
    }
}
