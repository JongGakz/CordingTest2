using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] numlist, int n) {
        int[] answer = new int[] {};
        return numlist.OrderBy(a => Math.Abs(a - n)).ThenByDescending(a => a).ToArray();
    }
}