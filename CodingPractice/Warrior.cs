using System;

class Warrior : Character1
{
    public Warrior(string name, int attackPower):base(name, attackPower)
    {
    }
    public override void Attack()
    {
        Console.WriteLine($"{_name}이(가) 칼로 베어냅니다! 데미지: {_attackPower}");
    }
}
