class Solution {
    public int[] solution(int[] num_list) {
        int a = 0;
        int b = 0;
        for (int i = 0; i < num_list.length; i++){
            if (num_list[i] % 2 == 0) {
                b++;
            } else {
                a++;
            }
        }
        int[] answer = {b,a};
        return answer;
    }
}