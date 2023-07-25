import java.util.*;

class Solution {
public int solution(int[] array) {
        return Arrays.stream(array).sorted().toArray()[array.length /2];
    }
}