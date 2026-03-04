using System;

class Mage : Character1
{
    public Mage(string name, int attackPower) : base(name, attackPower)
    {
    }
    public override void Attack()
    {
        Console.WriteLine($"{_name}이(가) 파이어볼을 시전합니다! 데미지: {_attackPower}");
    }
}
