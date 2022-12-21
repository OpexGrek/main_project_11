// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Input the data, separated by commas.");
string[] massive = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);    // Вводим числа через запятую и создаем массив удаляя все запятые
string[] newmassive = new string[massive.Length];                                           // Создаем новый массив для вывода условия задачи
Console.WriteLine("New array:");
int count = 0;
for (int i = 0; i < massive.Length; i++)                                                    // Цикл для заполнения нового массива
{
    if (massive[i].Length <= 3)                                                             // Условие заполнения нового массива
    {
        newmassive[i] = massive[i];
        Console.Write(newmassive[i] + " ");
        count = i + 1;
    }
}
if (count == 0)                                                                             // Вывод информации, что массив пустой
    Console.WriteLine("No values suitable for the conditions of the task");