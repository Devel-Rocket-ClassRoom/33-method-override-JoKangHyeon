using System;

class Car : Vehicle
{
    public Car(string name, int speed=120) : base(name, speed)
    {
    }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 도로를 달립니다! 속도: {Speed}km/h");
    }
}
