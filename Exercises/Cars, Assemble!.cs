using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed) 
    {
        if (speed == 0)
        {
            return 0;
        }
        else if (speed > 0 && speed <= 4)
        {
            return 1;
        }
        else if (speed > 4 && speed <= 8)
        {
            return 0.9;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else if (speed == 10)
        {
            return 0.77;
        }
        else
        {
            return speed;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double sucRate = SuccessRate(speed);
        int carsPerHour = speed * 221;
        return sucRate * carsPerHour;
       
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double sucRate = SuccessRate(speed);
        double carsPerMinute = (double)(speed * 221)/60;
        double res = (sucRate * carsPerMinute);
        return (int)res;
    
    }
}
