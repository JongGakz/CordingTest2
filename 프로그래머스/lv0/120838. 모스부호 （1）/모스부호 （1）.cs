using System;

public class Solution {
 public string solution(string letter)
            {
                string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

                string[] strings = letter.Split(" ");

                string answer = "";

                for (int i = 0; i < strings.Length; i++)
                {
                    for (int j = 0; j < morse.Length; j++)
                    {
                        if (strings[i].Equals(morse[j]))
                        {
                            answer += (char)(j + 97);            
                        }
                    }
                    
                }

                
                return answer;
            }
}