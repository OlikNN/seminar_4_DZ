// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
string number = Console.ReadLine();
char[] array = number.ToCharArray();
int num, sum=0;


for (int i = 0; i < array.Length; i++)
{
    num = int.Parse(Convert.ToString(array[i]));
    // Console.WriteLine(num);
    sum = sum + num;
}
Console.WriteLine($"Сумма: {sum}");
