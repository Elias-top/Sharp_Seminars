// See https://aka.ms/new-console-template for more information
//int num_1 = 0;
//int num_2 = 0;
Console.Clear();
string user_input = "";
int user_num = 0;
int result = 0;
Console.Write("Введите первое число: ");
user_input = Console.ReadLine() ?? "";
user_num = int.Parse(user_input);
result = user_num * user_num;
Console.WriteLine($"Ваше число {user_num} в квадрате равняется {result}");
