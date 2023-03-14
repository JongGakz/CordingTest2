class Solution {
   public String solution(String my_string) {

        String[] split = my_string.split("");

        for (int i = 0; i < split.length; i++) {
            for (int j = i + 1; j < split.length ; j++) {
                if (split[i].equals(split[j])) {
                    split[j] = "";
                }
            }
        }

        String answer = "";
        for (int i = 0; i < split.length; i++)
            answer += split[i];
        return answer;
    }
}