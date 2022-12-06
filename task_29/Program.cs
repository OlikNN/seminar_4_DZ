// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем


int[] array = new int[8];

for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Введите {i + 1} число");
    array[i] = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(i);
}
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"вывод {i + 1} числа - {array[i]}");
}
