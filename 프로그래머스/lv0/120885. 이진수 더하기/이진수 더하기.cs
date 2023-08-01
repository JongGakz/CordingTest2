using System;

public class Solution {
    public string solution(string bin1, string bin2)
        {
            string answer = "";
            int v1 = Convert.ToInt32(bin1, 2);
            int v2 = Convert.ToInt32(bin2, 2);

            int answerInt = v1 + v2;
            string v = Convert.ToString(answerInt, 2);
            return v;
        }

}