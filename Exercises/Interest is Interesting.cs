using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
       if (balance < 0)
       {
           return 3.213f;
       }
        else if ((balance >= 0 && balance < 1000))
        {
            return 0.5f;
        }
         else if ((balance >=  1000 && balance < 5000))
        {
            return 1.621f;
        }
         else if (balance >=  5000)
        {
            return 2.475f;
        }
        else 
        {
            return (float)0;
        }
    }

    public static decimal Interest(decimal balance)
    {
        decimal intRate = (decimal)InterestRate(balance);
        decimal yearInterest = (intRate * balance)/100;
        return yearInterest;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal interest = Interest(balance);
        decimal balanceUpdate = interest + balance;
        return balanceUpdate;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
       int year = 0;
           
       while (balance < targetBalance)
       {
            decimal updateInterest = Interest(balance);
            balance += updateInterest;
            year++;
        }
        return year;
    }
}
