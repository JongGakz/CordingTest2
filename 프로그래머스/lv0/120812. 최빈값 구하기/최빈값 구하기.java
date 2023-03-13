class Solution {
   public int solution(int[] array) {
        int answer = 0;
        int maxCount = 0;
        for (int i = 0; i < array.length; i++) {
            int count = 0;
            for (int j = 0; j < array.length; j++) {
                if (array[i] == array[j]) {
                    count++;
                    if (maxCount < count) {
                        maxCount = count;
                        answer = array[i];
                    }else if (maxCount == count && answer != array[i]) {
                        answer = -1;
                    }
                }
            }
        }
        return answer;
    }
}