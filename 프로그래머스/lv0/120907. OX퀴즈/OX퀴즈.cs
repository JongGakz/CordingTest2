using System;

public class Solution {
    public string[] solution(string[] quiz)
        {
       

            for (int i = 0; i < quiz.Length; i++)
            {
                string[] strings = quiz[i].Split(" ");

                if (strings[1].Equals("+"))
                {
                    if (int.Parse(strings[0]) + int.Parse(strings[2]) == int.Parse(strings[4]))
                    {
                        quiz[i] = "O";
                    }
                    else
                    {
                        quiz[i] = "X";
                    }
                }
                else
                {
                    if (int.Parse(strings[0]) - int.Parse(strings[2]) == int.Parse(strings[4]))
                    {
                        quiz[i] = "O";
                    }
                    else
                    {
                        quiz[i] = "X";
                    }
                } 
            }
            return quiz;
        }
}