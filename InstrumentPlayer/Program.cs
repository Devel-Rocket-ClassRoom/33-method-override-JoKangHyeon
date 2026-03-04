using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Instrument[] instruments = new Instrument[]
{
    new Piano("피아노"),
    new Guitar("기타"),
    new Drum("드럼")
};

Console.WriteLine("=== 악기 연주회 ===");
foreach (var instrument in instruments)
{
    instrument.Tune();
    instrument.Play();
    Console.WriteLine();
}
