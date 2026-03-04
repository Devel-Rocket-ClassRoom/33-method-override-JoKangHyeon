class Product
{
    protected string Name { get; set; }
    protected int Price { get; set; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - ₩{Price:N0}";
    }

    public virtual string GetDescription()
    {
        return "상품입니다.";
    }
}
