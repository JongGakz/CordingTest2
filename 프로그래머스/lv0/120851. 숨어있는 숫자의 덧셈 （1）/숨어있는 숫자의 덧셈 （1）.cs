using System;

public class Solution {
  
            public int solution(string my_string)
            {
                int answer = 0;

                for (int i = 0; i < my_string.Length; i++)
                {
                    if (my_string[i] < 65)
                    {
                        answer += my_string[i] - 48;
                    }
                }
                return answer;
            }
}