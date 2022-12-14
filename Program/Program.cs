/*
Создать программу, которая из имеющегося массива строк
формирует массив из строк, длина которых
меньше либо равна 3 символа.
Первоначальный массив можно вводить с клавиатуры,
либо задать на старте выполнения алгоритма.
*/
//Контроль ввода
int InputControl(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Вы ввели значение меньше допустимого. Пожалуйста введите корректное значение.");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Пожалуйста введите корректное значение.");
        }
    }
}
//Метод ввода массива с клавиатуры
string[] FillArray(string[] array)
{
    Console.Clear();
    for (int i = 0; i < array.Length; i++)
    {
        {
            Console.WriteLine($"Введите значение в {i + 1}-й элемент массива. Осталось заполнить {array.Length - i} элементов.");
            array[i] = Console.ReadLine();
            if (array[i] == "")
            {
                Console.WriteLine($"{i + 1}-й элемент массива содержит 0 символов");
            }
        }
    }
    return array;
}
//Метод печати массива в консоль
void PrintArray(string[] array, string message)
{
    Console.Write(message);
    Console.WriteLine();
    for (int i = 0; i + 1 < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write($"\"{array[array.Length - 1]}\"");
    Console.WriteLine();

}
//Метод определяющий размер нового массива и заполненяющий массив строками в которых меньше четырех символов
string[] FillResultArray(string[] originalArray)
{
    int newArraySize = 0;
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length < 4)
        {
            newArraySize++;
        }
    }
    string[] resultArray = new string[newArraySize];
    if (newArraySize == 0)
    {
        Console.WriteLine("В введенном Вами массиве нет элементов короче четырех символов!");
        Environment.Exit(0);
    }
    {
        int j = 0;
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length < 4)
            {
                resultArray[j] = originalArray[i];
                j++;
            }
        }
        return resultArray;

    }
}
//Основной код
int arraySize = InputControl("Введите размер массива.");
Console.Clear();
string[] arrayString = new string[arraySize];
FillArray(arrayString);
Console.Clear();
PrintArray(arrayString, "Введенный Вами массив:");
string[] resultArrayString = FillResultArray(arrayString);
PrintArray(resultArrayString, "Массив из элементов в которых меньше четырех символов:");
