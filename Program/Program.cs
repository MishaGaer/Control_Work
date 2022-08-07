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

//Основной код
int arraySize = InputControl("Введите размер массива.");
Console.Clear();
