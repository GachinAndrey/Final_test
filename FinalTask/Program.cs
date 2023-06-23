/*Задача: Написать программу, 
которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] SecondArrayString(string[] arr1, int n)
{
    int size = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= n) size += 1;
    }
    string[] arr2 = new string[size];

    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= n)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
    return arr2;
}

void PrintArray(string[] arr)
{
    Console.Write($"[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + ", ");
        }
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

string[] array1;
Console.WriteLine("Введите элементы массива через пробел: ");
string elementArray1 = Console.ReadLine();//ввод пользователем элементов массива
array1 = elementArray1.Split(" ");//сплит элементов массива по пробелу
Console.WriteLine("Введите максимальный размер искомых элементов: ");
int sizeElem = Convert.ToInt32(Console.ReadLine()); //здесь реализовал пользовательский ввод максимальной
                                                    //длины искомых элементов, но можно и просто поставить 3.
if (sizeElem > 0) //проверка ввода пользователем максимальной длины элемента
{
    Console.WriteLine("Исходный массив:");
    PrintArray(array1);
    string[] array2 = SecondArrayString(array1, sizeElem);
    Console.WriteLine();
    Console.WriteLine($"Массив с размером элементов до {sizeElem} знаков:");
    PrintArray(array2);
}
else Console.WriteLine("Ошибка ввода максимальной длины искомого элемента массива!");
