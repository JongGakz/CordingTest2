using System;

public class Solution {
   public string solution(string polynomial)
        {
            string answer = "";
            string[] strings = polynomial.Split(" + ");

            int a = 0;
            int b = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Contains("x"))
                {
                    if (strings[i].Replace("x", "") == "")
                    {
                        a++;
                    }
                    else
                    {
                        a += int.Parse(strings[i].Replace("x", ""));
                    }
                }
                else
                {
                    b += int.Parse(strings[i]);
                }
            }

             if (a == 1 && b == 0)
            {
                return "x";
            }
            if (a == 0 && b == 0) 
            {
                return 0.ToString();
            }
            if (a == 0)
            {
                return b.ToString();
            } 
            else if (b == 0) 
            {
                return a.ToString() + "x";    
            }
          if (a == 1)
            {
                return "x + " + b.ToString();
            }
            return a.ToString() + "x + " + b.ToString();
        }
}