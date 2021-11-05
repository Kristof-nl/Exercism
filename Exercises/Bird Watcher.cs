using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeekBirds = { 0, 2, 5, 3, 7, 8, 4 };
        return lastWeekBirds;
    }

    public int Today()
    {
        int lastIndex = birdsPerDay.Length - 1;
        return birdsPerDay[lastIndex];
    }

    public void IncrementTodaysCount()
    {
        int lastIndex = birdsPerDay.Length - 1;
        birdsPerDay[lastIndex]++;
        
    }

    public bool HasDayWithoutBirds()
    {
        int a = Array.IndexOf(birdsPerDay, 0);
        if (a == -1)
        {
            return false;
        }
        else {
            return true;
        }
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int counter = 0;
        for (int i = 0; i < numberOfDays; i++ )
        {
            counter += birdsPerDay[i];
        }
        return counter;
    }

    public int BusyDays()
    {
        int counter = 0;
        for (int i = 0; i < birdsPerDay.Length; i++ )
        {
            if (birdsPerDay[i] >= 5)
            {
                counter++;
            }
        }
        return counter;
    }
}
