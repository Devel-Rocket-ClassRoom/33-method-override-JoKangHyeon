using System;

class Boat :Vehicle
{
    public Boat(string name, int speed = 60) : base(name, speed)
    {
    }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 바다를 항해합니다! 속도: {Speed}km/h");
    }
}