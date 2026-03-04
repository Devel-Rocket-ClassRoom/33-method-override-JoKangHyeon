using System;

class Archer : Character1
{
    public Archer(string name, int attackPower) : base(name, attackPower)
    {
    }
    public override void Attack()
    {
        Console.WriteLine($"{_name}이(가) 화살을 쏩니다! 데미지: {_attackPower}");
    }
}
