using System;

public class Solution {
    public long solution(int balls, int share)
            {
                // Math.Min()은 둘중 더 작은 값을 반환함
                share = Math.Min(balls - share, share);

                // 재귀함수를 돌면서 share가 0이면 1을 리턴
                if (share == 0)
                    return 1;

                // 재귀함수를 통해 balls와 share를 1씩 줄임
                long answer = solution(balls - 1, share - 1);
                answer *= balls;
                answer /= share;

                // 한줄 코드 return share == 0 ? 1 : solution(balls - 1, share -1) * balls / share;
                return answer;
            }
}