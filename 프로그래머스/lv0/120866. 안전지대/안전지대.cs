using System;

public class Solution {
     public int solution(int[,] board)
        {
            int answer = 0;
            int[,] answerBoard = new int[board.GetLength(0), board.GetLength(0)];
            
         
         if (board.GetLength(0) == 1) 
         {
             if (board[0,0] == 1) return 0;
             else return 1;
         }
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    if (board[i, j] == 1)
                    {
                        if (i == 0 && j == 0)
                        {
                           answerBoard[0, 0]++;
                           answerBoard[0, 1]++;
                           answerBoard[1, 0]++;
                           answerBoard[1, 1]++;
                        }
                        else if (i == 0 && j == board.GetLength(0) - 1)
                        {
                            answerBoard[0, j]++;
                            answerBoard[0, j - 1]++;
                            answerBoard[1, j]++;
                            answerBoard[1, j - 1]++;
                        }
                        else if (i == board.GetLength(0) - 1 && j == 0)
                        {
                            answerBoard[i, 0]++;
                            answerBoard[i - 1, 0]++;
                            answerBoard[i - 1, 1]++;
                           answerBoard[i, 1]++;
                        }
                        else if (i == board.GetLength(0) - 1 && j == board.GetLength(0) - 1)
                        {
                            answerBoard[i, j]++;
                           answerBoard[i - 1, j]++;
                            answerBoard[i - 1, j - 1]++;
                            answerBoard[i, j - 1]++;
                        }
                        else if (i == 0)
                        {
                            answerBoard[0, j]++;
                           answerBoard[0, j - 1]++;
                            answerBoard[0, j + 1]++;
                           answerBoard[1, j]++;
                            answerBoard[1, j - 1]++;
                            answerBoard[1, j + 1]++;
                        }
                        else if (i == board.GetLength(0) - 1)
                        {
                            answerBoard[i, j]++;
                            answerBoard[i, j - 1]++;
                            answerBoard[i, j + 1]++;
                            answerBoard[i - 1, j]++;
                            answerBoard[i - 1, j - 1]++;
                            answerBoard[i - 1, j + 1]++;
                        }
                        else if (j == 0)
                        {
                            answerBoard[i, 0]++;
                            answerBoard[i + 1, 0]++;
                            answerBoard[i - 1, 0]++;
                            answerBoard[i, 1]++;
                            answerBoard[i + 1, 1]++;
                            answerBoard[i - 1, 1]++;
                        }
                        else if (j == board.GetLength(0) - 1)
                        {
                            answerBoard[i, j]++;
                            answerBoard[i + 1, j]++;
                            answerBoard[i - 1, j]++;
                            answerBoard[i, j - 1]++;
                            answerBoard[i + 1, j - 1]++;
                            answerBoard[i - 1, j - 1]++;
                        }
                        else
                        {
                            answerBoard[i, j]++;
                            answerBoard[i + 1, j]++;
                            answerBoard[i - 1, j]++;
                            answerBoard[i, j + 1]++;
                            answerBoard[i, j - 1]++;
                            answerBoard[i + 1, j + 1]++;
                            answerBoard[i + 1, j - 1]++;
                            answerBoard[i - 1, j + 1]++;
                            answerBoard[i - 1, j - 1]++;
                        }
                    }
                }
            }

            for (int i = 0; i < answerBoard.GetLength(0); i++)
            {
              
                for (int j = 0; j < answerBoard.GetLength(0); j++)
                {
                    

                    if (answerBoard[i, j] == 0)
                    {
                        answer++;
                    }
                    
                }
            }
                    return answer;
        }
}