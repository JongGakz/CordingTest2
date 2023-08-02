using System;

public class Solution {
     public int solution(string[] spell, string[] dic)
        {
            int answer = 0;
            for (int i = 0; i < dic.Length; i++)
            {   
                for (int j = 0; j < spell.Length; j++)
                {
                    if (!(dic[i].Contains(spell[j])))
                    {
                        break;
                    }

                    dic[i] = dic[i].Replace(spell[j], string.Empty);

                    if (dic[i] == string.Empty && j == spell.Length - 1)
                    {
                        return 1;
                    }
                }
            }
            return 2;
        }
}