// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Calculate(int A, int B)
{
    int res = 1;
    for (int i = 1; i <= B; i++)
    {
        //Console.WriteLine(i);
        res *= A; 
    }
    return res;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    while (num < 1)
    {
        Console.WriteLine($"{message} больше 0");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}


int number1 = GetNumber("Введите первое число:");
int number2 = GetNumber("Введите второе число:");


int res = Calculate(number1, number2);
Console.WriteLine($"натуральная степень числа {number1} = {res}");


