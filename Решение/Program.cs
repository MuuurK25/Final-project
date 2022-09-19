// Задача :
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
// либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string[] array1 = new string[4] { "1", "23", "hello", "res" };
string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        if (i < array1.Length)
        {
            Console.Write($"{array1[i]} ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.Write("Исходный массив: ");
PrintArray(array1);
SecondArray(array1, array2);
Console.Write("Получившийся массив: ");
PrintArray(array2);