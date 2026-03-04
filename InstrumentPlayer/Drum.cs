using System;

class Drum : Instrument
{
    public Drum(string name) : base(name)
    {
    }
    public override void Play()
    {
        Console.WriteLine($"🥁 드럼을 두드립니다 - 둥둥둥~");
    }
    public override void Tune()
    {
        Console.WriteLine($"드럼을(를) 조율합니다");
    }
}