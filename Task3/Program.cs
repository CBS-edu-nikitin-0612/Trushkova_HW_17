// See https://aka.ms/new-console-template for more information
using Task3; //без явного указания не работает программа, тк не видит другие классы

Console.WriteLine("Hello, Teacher!");

int[] array = new int[30];
for (int i = 0; i < array.Length; i++)
{
    Random random = new Random();
    array[i] = random.Next(0, 100);
}

Console.WriteLine("Initial array:");
Console.WriteLine(string.Join(" ", array));
Console.WriteLine("Sorted array");
DateTime dateTimeNow1 = DateTime.Now;
Console.WriteLine("Burbble " + string.Join(" ", array.SortingArrayBubble()));
TimeSpan timeSpan1 = DateTime.Now - dateTimeNow1;
DateTime dateTimeNow2 = DateTime.Now;
Console.WriteLine("Shaker  " + string.Join(" ", array.SortingArrayShaker()));
TimeSpan timeSpan2 = DateTime.Now - dateTimeNow2;
DateTime dateTimeNow3 = DateTime.Now;
Console.WriteLine("Comb    " + string.Join(" ", array.SortingArrayComb()));
TimeSpan timeSpan3 = DateTime.Now - dateTimeNow3;
DateTime dateTimeNow4 = DateTime.Now;
Console.WriteLine("Insert  " + string.Join(" ", array.SortingArrayInsert()));
TimeSpan timeSpan4 = DateTime.Now - dateTimeNow1;

Console.WriteLine($"\nВремя для Burbble {timeSpan1.TotalMilliseconds}");
Console.WriteLine($"Время для Shaker {timeSpan2.TotalMilliseconds}");
Console.WriteLine($"Время для Comb {timeSpan3.TotalMilliseconds}");
Console.WriteLine($"Время для Insert {timeSpan4.TotalMilliseconds}");