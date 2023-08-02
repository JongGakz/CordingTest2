using System;

public class Solution {
     public string[] solution(string my_str, int n)
        {
            string[] answer = new string[my_str.Length % n  == 0 ? my_str.Length / n : my_str.Length / n + 1];
            int a = 0;
            for (int i = 0; i < my_str.Length; i++)
            {
                if (i == 0) 
                {
                    answer[i] += my_str[i];    
                    continue;
                }
                answer[i / n] += my_str[i];
            }
            return answer;
        }

}