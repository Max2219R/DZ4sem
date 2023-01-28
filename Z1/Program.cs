/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.Не использовать Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int numberA = Number("Введите число A: ");
int numberB = Number("Введите число B: ");

Step(numberA, numberB);

void Step(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"{numberA} в {numberB} степени = {result}");
}

int Number(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

