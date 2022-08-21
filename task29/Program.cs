//Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран. Вводим массив через консоль

int [] numbers = new int[8];
Console.WriteLine("Мы создали массив: ");

Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
   numbers [i] = new Random().Next(0, 7);
    Console.Write(" " + arr (i) + " " );
 }

Console.Write( "]");

int arr (int a)
{
    return numbers[a];
}





