/*
Проверочная работа
Что требуется:

1 Создать репозиторий на GitHub
2 Создать readme-файл c описанием основных пунктов решения задачи.
3 Дополнительно добавить в репозиторий блок-схему с алгоритмом
    самой сложной(по вашему мнению) части задачи из п.2
4 Написать программу, решающую поставленную задачу
5 Вся работа разбивается на логические единицы зафиксированнаые отдельным коммитом

Задача: Написать программу, которая из сформированного массива строк
    содержащих символы и числа создать массив из строк,
    в который попадут только символы, не являющиеця цифрами.

Входные данные можно получить путём ввода с клавиатуры, но лучше сделать автогенерацию данных.
При решении не использовать "читерство".

Решение:
1 написать метод заполнения массива сгенерированных данных.
2 написать метод сортитровки массива на символы и числа.
3 распечатать массив строк.

*/



// Заполняем массив
char[] GenerateRandom(int size)
{
    //генератор чисел и букв.
    char[] textDigit = new char[size];

    for (int i = 0; i < size; i++)
    {
        Char c = (char)new Random().Next('0', 'z');
        if (((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')))
        {
            textDigit[i] = c;
        }
    }
    return textDigit;
}



// Сортируем массив
char[] SortArray(char[] textDigit, int size)
{
    int count = 0;
    foreach (char item in textDigit)
    {
        if (!char.IsDigit(item))
        {
            count++;
        }
    }
    //Отделяем массив от чисел.
    char[] newStrings = new char[count];
    
    int k = 0;
    foreach (char item in textDigit)
    {
        if (!char.IsDigit(item))
        {
            newStrings[k] = item;
            k++;
        }
    }
    return newStrings;
}



int size = 20;  // - длина массива. 

Console.WriteLine("Исходный массив: ");
char[] array = GenerateRandom(size);
Console.WriteLine(array);
Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
Console.Write(SortArray(array, size));
Console.WriteLine();

