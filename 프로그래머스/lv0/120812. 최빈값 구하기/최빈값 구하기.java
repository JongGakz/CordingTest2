import java.util.*;

class Solution {
   public int solution(int[] array) {
        Map<Integer, Integer> maps = new HashMap<>();

        for (int i = 0; i < array.length; i++) {
            if (maps.containsKey(array[i])) {
                maps.put(array[i], maps.get(array[i]) + 1);
            } else {
                maps.put(array[i], 1);
            }
        }

//        for (int i = 0; i <= 1000; i++) {
//            if (maps.get(i) != null) {
//                System.out.println(i + "=" + maps.get(i));
//            }
//        }

        int temp = 0;
        int temp2 = 0;
        int answer = 0;

        for (int i = 0; i <= 1000; i++) {
            if (maps.get(i) != null) {
                if (maps.get(i) >= temp) {
                    answer = i;
                    temp2 = temp;
                    temp = maps.get(i);
                }
            }
        }
        if (temp2 == temp) return -1;
        return answer;
    }
}