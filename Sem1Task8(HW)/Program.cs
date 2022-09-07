//=============================##008##=================================
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
//=====================================================================

Console.WriteLine("Программа показывает все чётные числа от 1 до N");  // Описание предназначения программы.
Console.Write("Введите число N: ");                     // Инструкция для действия. 
string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    if (inputNumberN > 0)
    {
        int startNumber = 2;
        while (startNumber <= inputNumberN - 2)
        {
            Console.Write(startNumber + ", ");
            startNumber += 2;
        }
        Console.Write(inputNumberN-1);
    }
}