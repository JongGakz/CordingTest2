using System;
using System.Linq;
public class Solution {
     public string solution(string s)
        {
            string answer = "";

            char[] chars = s.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char a = chars[i];
                for (int j = 0; j < chars.Length; j++)
                {
                    if (i != j && a == chars[j])
                    {
                        chars[i] = ' ';
                        chars[j] = ' ';
                    }
                }
            }

            answer = new string(chars.OrderBy(n => n).ToArray()).Replace(" ","");
            return answer;
        }
}