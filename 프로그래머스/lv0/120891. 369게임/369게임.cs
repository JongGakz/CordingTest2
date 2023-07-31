using System;
using System.Linq;

public class Solution {
     public int solution(int order)
            {
                int answer = 0;
                char[] chars = order.ToString().ToArray();

                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] - '0' == 3 || chars[i] - '0' == 6 || chars[i] - '0' == 9)
                        answer++;
                }


                return answer;
            }
}