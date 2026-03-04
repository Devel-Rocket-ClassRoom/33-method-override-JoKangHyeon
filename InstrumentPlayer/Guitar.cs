using System;

class Guitar : Instrument
{
    public Guitar(string name) : base(name)
    {
    }
    public override void Play()
    {
        Console.WriteLine($"🎸 기타 줄을 튕깁니다 - 통통통~");
    }
    public override void Tune()
    {
        Console.WriteLine($"기타 줄을 조율합니다");
    }
}
