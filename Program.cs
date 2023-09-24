// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

string[] FillArray (int size) // Метод заполняющий одномерный массив строковыми данными
{
    string[] array = new string[size];
    for (int i = 0; i<size; i++ )
    {
        array[i] = Console.ReadLine();
    }
    return array;  
}

string[] SortArray (string[] array) // Метод сортирующий и заполняющий новый массив с сортированными значениями
{
    string[] smallArray = new string [array.Length];    
    for (int i = 0; i < array.Length; i++)
    { 
        if (array[i].Length <= 3)
        {
            smallArray[i] = array[i];
        }
    }
    smallArray= smallArray.Where (x => x!=null).ToArray(); // функция удаляющая из отсортированного массива пустые элементы          
    return smallArray;
}
