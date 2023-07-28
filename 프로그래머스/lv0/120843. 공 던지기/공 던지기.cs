using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        return numbers[((k*2)-2) % numbers.Length];;
    }
}