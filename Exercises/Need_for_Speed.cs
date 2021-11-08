using System;

class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    public int drivenDistance = 0;
    public int batteryPercent = 100;
    

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
        
    public bool BatteryDrained()
    {
        return batteryPercent < batteryDrain;
    }

    public int DistanceDriven()
    {
        return drivenDistance;
    }

    public void Drive()
    {
        if (batteryPercent >= batteryDrain)
        {
          drivenDistance += speed;
          batteryPercent -= batteryDrain;  
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4); ;
    }
}

class RaceTrack
{
    public int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool CarCanFinish(RemoteControlCar car)
    {
       while (!car.BatteryDrained())
       {
           car.Drive();
       }

     return car.DistanceDriven() >= distance;
    }
}
