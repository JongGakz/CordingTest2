using System;

public class Solution {
    
            public string solution(int age)
            {
                string answer = "";
                string strings = age.ToString();
               
                for (int i = 0; i < strings.Length; i++)
                {
                  answer += (char)(int.Parse(strings[i].ToString()) + 97);
                }

                return answer;
            }
        
}