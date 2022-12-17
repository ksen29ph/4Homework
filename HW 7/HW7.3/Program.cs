// Программа, которая задает массив из 8 элементов и выводит их на экран.

int [] numbers = new int [8];
Console.Write("[");
for (int a = 0; a < numbers.Length; a++)
{
    numbers [a] = new Random().Next(0, 11);
    Console.Write(" " + Method (a) + " ");
}
Console.Write("]");
int Method (int i)
{
    return numbers[i];
}