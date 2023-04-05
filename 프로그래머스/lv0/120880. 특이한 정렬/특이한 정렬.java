
import java.util.*;

class Solution {
    public ArrayList<Integer> solution(int[] numlist, int n) {

        ArrayList<Integer> intList = new ArrayList<>();

        for (int i = 0; i < numlist.length; i++) {
            intList.add(Integer.valueOf(numlist[i]));
        }
        intList.sort(new Comparator<Integer>() {
            @Override
            public int compare(Integer o1, Integer o2) {
                int o1Int = o1.intValue();
                int o2Int = o2.intValue();

                if (Math.abs(o1Int-n) < Math.abs(o2Int-n)) return -1;
                else if (Math.abs(o1Int-n) > Math.abs(o2Int-n)) return 1;
                else return o2-o1;
            }
        });

        System.out.println(intList);

        return intList;
    }
}