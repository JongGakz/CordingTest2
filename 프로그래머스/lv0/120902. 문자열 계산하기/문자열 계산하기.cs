using System;

public class Solution {
     public int solution(string my_string)
        {
           
            string[] strings = my_string.Split(" ");
            int answer = int.Parse(strings[0]);
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Equals("+"))
                {

                    answer += int.Parse(strings[i + 1]);
                }
                else if (strings[i].Equals("-"))
                {
                    answer -= int.Parse(strings[i + 1]);
                }
            }
            return answer;
        }
}