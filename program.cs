using System;
class Program
{static void Main()
{int hp = 10;
int attack = 5;
int enemyHp = 20;
int choice;
do{
    Console.WriteLine("=== POSTAĆ ===");
    Console.WriteLine("HP: " + hp);
    Console.WriteLine("Atak: " + attack);
    Console.WriteLine();
        Console.WriteLine("=== PRZECIWNIK ===")
            Console.WriteLine("=== POSTAĆ ===")
Console.WriteLine("HP: " + enemyHp);
Console.WriteLine();
Console.WriteLine("1 - Leczenie");
Console.WriteLine("2 - Trening");
Console.WriteLine("3 - Atak na przeciwnika");
Console.WriteLine("0 - Zakończ program");
Console.WriteLine();
Console.WriteLine("Wybierz opcję: ");
string input = Console.ReadLine();
if (int.TryParse(input, out choice))
{
    if (choice == 1)
    {
        hp++;
        Console.WriteLine("Leczenie!");
        Console.WriteLine("HP zwiększone do " + hp);
    }
    else if (choice == 2)
    {
        attack++;
        Console.WriteLine("Trening!");
        Console.WriteLine("Atak zwiększony do " + attack);
    }
    else if (choice == 3)
    {
        if (enemyHp > 0)
        {
            Console.WriteLine("Atakujesz przeciwnika!");
enemyHp = enemyHp - attack;
if (enemyHp <= 0)
{
    enemyHp = 0;
    Console.WriteLine("Przeciwnik został pokonany!");
}
else{Console.WriteLine("Przeciwnik posiada jeszcze " + enemyHp + " HP. ")};
}
    }
    else{
        Console.WriteLine("Przeciwnik został już pokonany!");
    }
}
else if (choice == 0)
{
    Console.WriteLine("Komiec programu.");
}
else
{
    Console.WriteLine("Nieprawidłowa komenda!");
}
}
else{
    Console.WriteLine("Nieprawidłowa komenda!");
    choice = -1;
}
Console.WriteLine();
} while (choice != 0);
}





}}}