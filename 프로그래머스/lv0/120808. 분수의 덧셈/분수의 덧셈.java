class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        
        int x = denom1 * denom2;
        int y = (numer1 * (x / denom1)) + (numer2 * (x / denom2));
        
        
        for (int i = 1; i <= x; i++) {
            if (x % i == 0 && y % i == 0) {
                x = x / i;
                y = y / i;
                i = 1;
            }    
        }
           
        
            
        
        int[] answer = {y,x};
        return answer;
    }
}