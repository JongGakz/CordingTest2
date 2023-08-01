using System;

public class Solution {
      public int solution(string s)
        {
            int answer = 0;
            string[] strings = s.Split(" ");

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Equals("Z"))
                {
                    answer -= int.Parse(strings[i - 1]);
                }
                else
                {
                    answer += int.Parse(strings[i]);
                } 
                    
            }

            return answer;
        }
}