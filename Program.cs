//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//Ограничения:
//- Нельзя использовать класс Math
//- Должна быть отдельная функция Power, которая возвращает результат
//- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

double Power(int A, int B)
{
    double result = 1;
    for (int i = 0; i < B; i++)
    {
        result = result * A;
    }
   return result;
}
double res = Power(A, B);
Console.WriteLine(res);
