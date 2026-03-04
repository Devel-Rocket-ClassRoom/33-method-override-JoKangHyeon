using System;

class Food : Product
{
    protected DateTime ExpirationDate { get; set; }
    public Food(string name, int price, DateTime expirationDate) : base(name, price)
    {
        ExpirationDate = expirationDate;
    }
    public override string ToString()
    {
        return base.ToString() + $"(유통기한: {ExpirationDate:yyyy-MM-dd})";
    }
    public override string GetDescription()
    {
        return "식품입니다. 냉장 보관하세요.";
    }
}