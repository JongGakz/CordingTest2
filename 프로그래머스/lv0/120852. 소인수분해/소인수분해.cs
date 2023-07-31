using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int n)
            {
                int[] answer = new int[] { };
                List<int> array = new List<int>();
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        array.Add(i);
                        n = n / i;
                        i = 1;
                    }
                }
                return array.Distinct().ToArray();
            }
}