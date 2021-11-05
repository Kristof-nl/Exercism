using System;

class RemoteControlCar
{
    int distance = 0;
    int battery = 100;
    
    public static RemoteControlCar Buy()
    {
    var myRemoteControlCar = new RemoteControlCar();
    return myRemoteControlCar;
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        if (distance < 2000)
        {
            return $"Battery at {battery}%";
        }
        else 
        {
            return "Battery empty";
        }
    }

    public void Drive()
    {
        if (distance < 2000)
        {
        distance += 20;
        battery -= 1;
        }
        
    }
}
