// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// (Math.Pow использовать нельзя!!!)

// void Exponentiation(int a, int b)
// {
//     if (b <= 0)
//     {
//         Console.WriteLine("Введите натуральную степень!");
//     }
//     else if (b == 1)
//     {
//         Console.WriteLine($"Число {a} в степени {b} равно {a}");
//     }
//     else
//     {
//     int sum = a;
//     for (int i = 2; i <= b; i++)
//     {
//         sum = sum * a;
//     }
//     Console.WriteLine($"Ваше число {a} в степени {b} равно {sum}");
//     }
// }
// Console.Write("Введите число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень в которую вы хотите возвести: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Exponentiation(numA, numB);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// (Массивы и строки использовать нельзя!!!)

// int SummNumbers(int num)
// {
//     int summ = 0;
//     if (num < 0)
//         num = num * (-1);
//     while (num > 0)
//     {
//         summ = summ + num % 10;
//         num = num / 10;
//     }
//     return summ;
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int summ = SummNumbers(num);
// Console.Write($"Сумма цифр в числе {num} = {summ}");



// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.

// int [] RandomArray(int lenght)
// {
//     int [] arr = new int[lenght];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write("Введите элемент массива: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }
// Console.Write("Введите длинну массива: ");
// int lenght = Convert.ToInt32(Console.ReadLine());
// PrintArray(RandomArray(lenght));