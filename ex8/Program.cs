Console.Clear();

int user_num = 0;
int index_num = 1;

Console.WriteLine("Введите число: ");
user_num = int.Parse(Console.ReadLine() ?? "");


while(index_num <= user_num)
{
    if((index_num % 2) == 0)
    {
        Console.Write($"{index_num}, ");
    }
    index_num ++;
}


