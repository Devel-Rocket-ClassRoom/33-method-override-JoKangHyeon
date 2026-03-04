using System;

class Character1
{
    protected string _name;
    protected int _attackPower;

    public Character1(string name, int attackPower)
    {
        _name = name;
        _attackPower = attackPower;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{_name}이(가) 공격합니다. 데미지: {_attackPower}");
    }

    public override string ToString()
    {
        return $"[{_name}] 공격력: {_attackPower}";
    }
}
