// Программа, которая принимает на вход число и выдает сумму цифр в числе.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a > 0)
{
    int num = a % 10;
    a = a / 10;
    sum = sum + num;
    }

Console.Write("Сумма цифр в вашем числе: " + sum);
