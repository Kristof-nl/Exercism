using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
    double circlePoint  = Math.Pow(x, 2) + Math.Pow(y, 2);
       if (circlePoint <= 1)
       {
           return 10;
       }
       else if (circlePoint > 1 && circlePoint <= 25)
        {
            return 5;
        }
         else if (circlePoint > 25 && circlePoint <= 100)
        {
            return 1;
        }
       else 
       {
           return 0;
       }
    }
}
