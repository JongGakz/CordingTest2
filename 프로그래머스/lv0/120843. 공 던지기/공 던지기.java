class Solution {
public int solution(int[] numbers, int k) {
        int answer = 0;
        int i = 0;
        while (k != 1) {
            k--;
            i += 2;
            if (i >= numbers.length) {
                i = i - numbers.length;
            }
            answer = numbers[i];
        }

        return answer;
    }

}