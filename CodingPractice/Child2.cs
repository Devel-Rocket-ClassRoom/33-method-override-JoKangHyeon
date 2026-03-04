using System;

class Child2 : Parent2
{
    public override void Greet()
    {
        base.Greet();
        Console.WriteLine("반갑습니다.");
    }
}
