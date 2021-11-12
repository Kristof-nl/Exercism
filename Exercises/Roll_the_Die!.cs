using System;

public class Player
{
    public int RollDie()
    {    
        Random randValue = new Random();
        int num = randValue.Next(1, 18); 
        return num;
    }

    public double GenerateSpellStrength()
    {
        Random randValue = new Random();
        double spellStr = randValue.NextDouble(); 
        return spellStr * 100;
    }
}
