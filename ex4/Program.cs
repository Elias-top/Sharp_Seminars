Console.Clear();

int[] num_array = new int[3];

int max_num = num_array[0];
int index = 1;

Console.WriteLine("Введите первое число: ");
num_array[0] = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите второе число: ");
num_array[1] = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите третье число: ");
num_array[2] = int.Parse(Console.ReadLine() ?? "");

while(index < num_array.Length)
{
    if(max_num < num_array[index])
    {
        max_num = num_array[index];
    }
    index ++;
}

Console.WriteLine($"Максимальное из введеных чисел = {max_num}");

