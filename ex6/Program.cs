Console.Clear();
int user_num = 0;

Console.WriteLine("Введите число для проверки на четность: ");
user_num = int.Parse(Console.ReadLine() ?? "");

if((user_num % 2) == 0)
{
    Console.WriteLine($"Число {user_num} является четным");
}
else
{
    Console.WriteLine($"Число {user_num} не является четным");
}


