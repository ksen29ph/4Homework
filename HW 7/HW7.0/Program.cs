// Цикл, принимающий на вход 2 числа (А и В) и возводящий число А в настуральную степень В.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;
for (int i = 1; i < b; i++)
{
    step = step * a;
}
Console.Write("Ваш ответ: " + step);
