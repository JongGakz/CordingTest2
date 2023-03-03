import java.util.*;
import java.util.function.IntFunction;
import java.util.function.IntPredicate;
import java.util.function.Predicate;
import java.util.function.ToIntFunction;
class Solution {
     public int[] solution(int n) {

        ArrayList<Integer> list = new ArrayList<>();


        for (int i = 1; i <=n; i++) {
            if (n % i == 0) {
                list.add(i);
            }
        }
        int[] answer = list.stream().mapToInt(new ToIntFunction<Integer>() {
            @Override
            public int applyAsInt(Integer value) {
                return value;
            }
        }).toArray();
        return answer;
    }
}