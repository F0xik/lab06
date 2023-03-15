using System.IO;

Console.WriteLine("На оценку 3"); Console.WriteLine(" ");
Console.WriteLine("Введите число: ");
string num;
num = Console.ReadLine();
int[] nums = new int[num.Length];
int i = 0;
int sum = 0;
int umn = 1;
foreach (char n in num)
{
    nums[i] = Convert.ToInt32(n.ToString()); i++;
}
Console.WriteLine(string.Join(" ", nums));
for (int up = 0; up < nums.Length; up++)
{
    sum += nums[up]; umn *= nums[up];
}
Console.WriteLine($"Сумма чисел: {sum}" + " " +
    $"Произведение чисел: {umn} ");

Console.WriteLine(" ");
Console.WriteLine(" "); Console.WriteLine("На оценку 4");
Console.WriteLine(" ");


Console.WriteLine("Введите число: ");
string num1;
num1 = Console.ReadLine();
int[] nums1 = new int[num1.Length];
int i1 = 0;
Console.WriteLine("Введите второе число: ");
string num2;
num2 = Console.ReadLine();
int[] nums2 = new int[num2.Length];
int i2 = 0;



Console.WriteLine(String.Join("",nums1,"",nums2));
 

