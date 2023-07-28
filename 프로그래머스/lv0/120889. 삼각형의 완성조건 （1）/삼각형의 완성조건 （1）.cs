using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
   
            public int solution(int[] sides)
            {
                int answer = 0;
                List<int> list = sides.ToList();
                list.Sort();
                int[] sortedArray = list.ToArray();

                if (sortedArray[0] + sortedArray[1] > sortedArray[2])
                {
                    return 1;
                }
                else
                    return 2;

                
            }

}