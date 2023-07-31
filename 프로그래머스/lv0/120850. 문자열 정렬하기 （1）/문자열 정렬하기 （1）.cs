using System;
using System.Collections.Generic;

public class Solution {
   public int[] solution(string my_string)
            {
                List<int> array = new List<int>();
                for (int i = 0; i < my_string.Length; i++)
                {
                    if (my_string[i] < 65)
                    {
                        array.Add(my_string[i]-48);
                    } 
                }
                array.Sort();
                return array.ToArray();
            }

}