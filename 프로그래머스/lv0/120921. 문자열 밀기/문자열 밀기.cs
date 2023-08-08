using System;

public class Solution {
        public int solution(string A, string B)
        {
            int answer = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A.Equals(B))
                {
                    return answer;
                }
                A = A[A.Length - 1] + A.Substring(0, A.Length - 1);
                answer++;
            }
            return -1;
        }
}