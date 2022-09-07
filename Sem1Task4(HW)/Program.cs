//=============================##004##=================================
// Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
//=====================================================================

Console.WriteLine("Программа для нахождения максимального значения из трех чисел");  // Описание предназначения программы.

Console.Write("Введите первое число (A): ");              // Инструкция для первого действия. 
string? inputLineA = Console.ReadLine();                  // Читаем данные пользователя.
Console.Write("Введите второе число (B): ");              // Инструкция для второго действия.
string? inputLineB = Console.ReadLine();                  // Читаем данные пользователя.
Console.Write("Введите третье число (C): ");              // Инструкция для третьего действия.
string? inputLineC = Console.ReadLine();                  // Читаем данные пользователя.

if (inputLineA != null && inputLineB != null && inputLineC != null)   // Проверка на Null.
{
    int inputNumberA = int.Parse(inputLineA);             // Превращаем строку в число.
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);

    if (inputNumberA > inputNumberB)                      // Проводим сравнение
    {
        if (inputNumberA > inputNumberC)                  // Второе сравнение с победителем первого сравнения

        {
           Console.WriteLine("Максимальное число (A)");   // Выводим результат сравнения, если число А больше.
        }
    }

    else if (inputNumberB > inputNumberC)                 // Если А оказалось меньше, сравниваем B и C
    {
        Console.WriteLine("Максимальное число (B)");      // Выводим результат сравнения, если число B больше.
    }
    else
    {
        Console.WriteLine("Максимальное число (C)");      // Выводим результат сравнения, если число C больше.
    }
}