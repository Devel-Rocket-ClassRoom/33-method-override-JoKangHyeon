using System;

Vehicle[] vehicles = new Vehicle[]
{
    new Car("스포츠카"),
    new AirPlane("보잉747"),
    new Boat("요트")
};

Console.WriteLine("=== 경주 시작! ===");
foreach (var vehicle in vehicles)
{
    vehicle.Move();
}
