Console.WriteLine("Введите массив строк: ");
string [] array = new string [5];
for (int i = 0; i < array.Length; i++)
{
    array [i] = Console.ReadLine();
}
Console.WriteLine("Преобразованный массив: ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    Console.Write(array[i] + " ");
}