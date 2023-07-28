using System;

public class Solution {
  public string solution(string my_string)
            {
                string answer = "";
                for (int i = 0; i < my_string.Length; i++)
                {
                    char v = my_string[i];
                    if (v != 'e' && v != 'a' && v != 'i' && v != 'o' && v != 'u')
                    {
                        answer += my_string[i];
                    }
                        
                }
                

                return answer; 
            }
}