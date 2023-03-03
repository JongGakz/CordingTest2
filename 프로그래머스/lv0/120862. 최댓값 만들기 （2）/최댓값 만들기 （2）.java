import java.util.*;
class Solution {
 public int solution(int[] numbers) {
       int answer = 0;
        int[] ints = Arrays.stream(numbers).sorted().toArray();
        if(ints[0] * ints[1] < ints[ints.length-2] * ints[ints.length-1]) {
            return ints[ints.length-2] * ints[ints.length-1];
        } else return ints[0] * ints[1];
    }
}