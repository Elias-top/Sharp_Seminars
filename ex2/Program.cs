Console.Clear();
int first_num = 0;
int second_num = 0;

Console.WriteLine("Введите первое число: ");
first_num = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите второе число: ");
second_num = int.Parse(Console.ReadLine() ?? "");

if(first_num > second_num)
{
    Console.WriteLine($"Число a = {first_num} > числа b = {second_num}");
}
else if(first_num == second_num)
{
    Console.WriteLine($"Число a = {first_num} равно числу b = {second_num}");
}
else
{
    Console.WriteLine($"Число a = {first_num} < числа b = {second_num}");
}
