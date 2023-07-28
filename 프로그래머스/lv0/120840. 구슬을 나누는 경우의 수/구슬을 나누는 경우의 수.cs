using System;

public class Solution {
      public double solution(int balls, int share)
            {

                double a = 1;
                double b = 1;
                double c = 1;
                double d = balls - share;

                for (double i = 1; i <= balls; i++)
                {
                    a *= i;
                }
                for (double i = 1; i <= share; i++)
                {
                    b *= i;
                }
                for (double i = 1; i <= d; i++)
                {
                    c *= i;
                }


                 return Math.Round(a / (b * c));
            }

}