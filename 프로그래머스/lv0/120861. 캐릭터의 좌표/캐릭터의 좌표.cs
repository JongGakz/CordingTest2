using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board)
        {
            int[] answer = new int[] { 0, 0 };

            foreach (string s in keyinput)
            {
                if (s.Equals("left") && answer[0] != -(board[0] / 2))
                {
                    answer[0] -= 1;
                }
                else if (s.Equals("right") && answer[0] != (board[0] / 2))
                {
                    answer[0] += 1;
                }
                else if (s.Equals("up") && answer[1] != (board[1] / 2))
                {
                    answer[1] += 1;
                }
                else if (s.Equals("down") && answer[1] != -(board[1] / 2))
                {
                    answer[1] -= 1;
                }
            }
            return answer;
        }
}