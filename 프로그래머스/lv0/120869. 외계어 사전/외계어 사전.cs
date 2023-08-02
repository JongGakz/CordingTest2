using System;

public class Solution {
     public int solution(string[] spell, string[] dic)
        {
              int answer = 0;
        for(int i =0 ; i < dic.Length;i++)
        {
            for(int k =0 ; k < spell.Length;k++)
            {
                if(dic[i].Contains(spell[k]))
                {
                    dic[i] = dic[i].Replace(spell[k],String.Empty);

                    if(dic[i] == String.Empty && k == spell.Length-1)
                    {
                        return 1;
                    }
                }
                else
                {
                   break;
                }
            }
        }
        return 2;
        }

}