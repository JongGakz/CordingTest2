using System;
using System.Collections.Generic;
public class Solution {
      public int[] solution(int n)
            {
              
                List<int> array = new List<int>();
                int a = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        array.Insert(a++, i);
                }
                return array.ToArray();
            }
}