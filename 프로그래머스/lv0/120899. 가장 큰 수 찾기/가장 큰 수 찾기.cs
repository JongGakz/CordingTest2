using System;
using System.Linq;
public class Solution {
      public int[] solution(int[] array)
            {
                int[] answer = new int[2];
                int[] index = (int[])array.Clone();

                Array.Sort(array);

                for (int i = 0; i < index.Length; i++)
                {
                    if (index[i] == array.Max())
                    {
                        answer[0] = index[i];
                        answer[1] = i;
                    }
                }


                return answer;
            }
}