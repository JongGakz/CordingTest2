using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
        public string solution(string my_string)
        {
            string answer = "";
            List<char> list = my_string.ToLower().ToList();
            list.Sort();
            
            foreach(var s in list)
            {
                answer += s;
            }

            return answer;
        }
}