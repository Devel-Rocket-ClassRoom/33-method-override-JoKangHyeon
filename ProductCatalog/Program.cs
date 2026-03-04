using System;

Product[] products = new Product[3]
{
    new Electronics("노트북", 1_500_000, 24),
    new Clothing("청바지", 89_000, "M"),
    new Food("우유", 3500, new DateTime(2026,06,15))
};

Console.WriteLine("=== 상품 카탈로그 ===");
foreach(var product in products)
{
    Console.WriteLine(product);
    Console.WriteLine($"  → {product.GetDescription()}");
}
ㄴ