using System;
using System.Text.RegularExpressions;
public class Solution {
     public int solution(string my_string)
        {
            int answer = 0;

            my_string =  Regex.Replace(my_string,"[A-z]", " ");

            string[] strings = my_string.Split(" ");

            foreach (var i in strings)
            {
                if (!i.Equals(""))
                answer += int.Parse(i);
            }

            return answer;
            
        }
}