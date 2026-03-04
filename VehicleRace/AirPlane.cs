using System;

class AirPlane :Vehicle
{
    public AirPlane(string name, int speed = 900) : base(name, speed)
    {
    }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 하늘을 납니다! 속도: {Speed}km/h");
    }
}
