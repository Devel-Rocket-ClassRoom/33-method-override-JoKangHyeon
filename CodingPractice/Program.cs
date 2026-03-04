using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

Console.WriteLine();
Console.WriteLine("### 1-1. 기본 사용법");

Parent parent = new Parent();
Parent child = new Child();

parent.Work();
child.Work();



Console.WriteLine();
Console.WriteLine("### 1-2. 다형성과 오버라이드");

Animal animal = new Animal();
Animal cat = new Cat();
animal.Eat();
cat.Eat();



Console.WriteLine();
Console.WriteLine("## 2. new vs override 동작 비교");

Child1 child1 = new Child1();
Parent1 parent1 = child1;

child1.Say();
child1.Run();
child1.Walk();

Console.WriteLine();
parent1.Say();
parent1.Run();
parent1.Walk();



Console.WriteLine();
Console.WriteLine("### 3-1. 오버로드");

Calculator calculator = new Calculator();
Console.WriteLine(calculator.Add(1, 2));
Console.WriteLine(calculator.Add(1.0, 3.0)) ;
Console.WriteLine(calculator.Add(1, 2, 3));



Console.WriteLine();
Console.WriteLine("### 3-2. 오버라이드");

Animal1 animal1 = new Animal1();
Animal1 dog1 = new Dog1();
Animal1 cat1 = new Cat1();

animal1.Speak();
dog1.Speak();
cat1.Speak();



Console.WriteLine();
Console.WriteLine("### 4-1. base 키워드 기본");

Parent2 parent2 = new Child2();
parent2.Greet();



Console.WriteLine();
Console.WriteLine("### 4-2. base 키워드 활용");

Parent3 parent3 = new GrandChild3();
parent3.Work();



Console.WriteLine();
Console.WriteLine("## 5. 메서드 오버라이드 봉인 (sealed)");

new Parent4().Work();
new Child4().Work();
new GrandChild4().Work();
new GrandChild4().Play();



Console.WriteLine();
Console.WriteLine("### 6-1. 기본 동작 확인");

Person person = new Person();
Console.WriteLine(person);
Console.WriteLine(person.ToString());



Console.WriteLine();
Console.WriteLine("### 6-2. ToString() 오버라이드");

Person2 person2 = new Person2("박용준");
Console.WriteLine(person2);



Console.WriteLine();
Console.WriteLine("### 6-3. 게임 캐릭터 예제");

Character character1 = new Character("용사", 10, 100);
Character character2 = new Character("마법사", 8, 70);

Console.WriteLine(character1);
Console.WriteLine(character2);



Console.WriteLine();
Console.WriteLine("### 7-1. RPG 캐릭터 시스템");

Character1 warrior = new Warrior("전사", 50);
Character1 mage = new Mage("마법사", 60);
Character1 archer = new Archer("궁수", 40);

Console.WriteLine(warrior);
Console.WriteLine(mage);
Console.WriteLine(archer);

Console.WriteLine();
warrior.Attack();
mage.Attack();
archer.Attack();



Console.WriteLine();
Console.WriteLine("### 7-2. 다형성 활용");

Console.WriteLine("=== 파티 공격 ===");
Character1[] characters = new Character1[] { warrior, mage, archer };
foreach(Character1 c in characters)
{
    c.Attack();
}