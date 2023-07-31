using System;
using System.Linq;
public class Solution {
       public string solution(string my_string, int num1, int num2)
            {
                string answer = "";

                char v1 = my_string[num1];



                char[] strings = my_string.ToArray<char>();

                strings[num1] = strings[num2];
                strings[num2] = v1;

                for (int i = 0; i < my_string.Length; i++)
                {
                    answer += strings[i];
                }

                return answer;
            }
}