class Character
{
    string _name;
    int _level;
    int _health;

    public Character(string name, int level, int health)
    {
        _name = name;
        _level = level;
        _health = health;
    }

    override public string ToString()
    {
        return $"[{_name}] Lv.{_level} HP:{_health}";
    }
}
