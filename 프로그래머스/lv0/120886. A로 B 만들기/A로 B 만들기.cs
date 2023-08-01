using System;
using System.Linq;
public class Solution {
    public int solution(string before, string after) {
                  return new string(before.OrderBy(n => n).ToArray()).Equals(new string(after.OrderBy(n => n).ToArray())) ? 1 : 0;

    }
}