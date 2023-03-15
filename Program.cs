using System.IO;
using System.Linq;
Console.WriteLine("На оценку 3"); Console.WriteLine(" ");
Console.WriteLine("Введите число: ");
string num;
num = Console.ReadLine();
int[] nums = new int[num.Length];
int i = 0;
int sum = 0; // сумма
int umn = 1; // умножение
foreach (char n in num)
{
    nums[i] = Convert.ToInt32(n.ToString()); i++;
}
Console.WriteLine(string.Join(" ", nums));
for (int up = 0; up < nums.Length; up++) // сумма и умножение
{
    sum += nums[up]; umn *= nums[up];
}
int max = nums.Max();  // Макc знач
int min = nums.Min();   // Мин знач
Console.WriteLine($"Сумма чисел: {sum}" + " " +
    $"Произведение чисел: {umn} ");
Console.WriteLine($"Максимальное значение: {max}" + " " + $"Минимальное значение: {min}");


