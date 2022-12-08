// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Пример:
// ["hello". "2", "world", ":-)"] -> ["2", ":-)"]

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


string[] LessFourSimbolsArray(string[] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < number + 1)
        {
            count += 1;
        }
    }

    string[] newArr = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
 
        if (array[i].Length < number + 1)
        {
            newArr[j] = array[i];
            j++;
        }

    }
    return newArr;
}
string[] textArray = { "Маша", "Оля", "Ян", "Петя", "Ира" };
int num = 3;
PrintArray(textArray);
string[] lessFourSimbolsArray = LessFourSimbolsArray(textArray, num);
PrintArray(lessFourSimbolsArray);