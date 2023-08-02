using System;

public class Solution {
     public int solution(string[] spell, string[] dic)
        {
            int answer = 2;
            for (int i = 0; i < dic.Length; i++)
            {
                for (int j = 0; j < spell.Length; j++) // Fixed the loop index from i to j
                {
                    if (!(dic[i].Contains(spell[j])))
                    {
                        break;
                    }
                    dic[i] = dic[i].Replace(spell[j], "");

                    if (dic[i].Equals("") && j == spell.Length - 1)
                    {
                        answer = 1; // Set answer to 1 if the condition is met
                        break; // We can break here since we already know the answer is 1
                    }
                }
            }
            return answer;
        }

}