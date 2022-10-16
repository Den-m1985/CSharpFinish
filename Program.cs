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
1 написать метод создания массива
2 написать метод заполнения массива сгенерированных данных.
3 написать метод сортитровки массива на символы и числа.
4 написать метод распечатки массива строк.
5 заполнить методы значениями.
*/
/*
//создаеи массив
string[] CreateArray(int size)
{
    string[] array = new string[size];
    return array;
}
*/
/*
// Заполняем массив
void FillArray(string[] array)
{

}
*/

// Сортируем массив
void SortArray(string strings)
{
    string str = "";
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i] >= '0' && strings[i] <= '9')
        {
        }
        else
        {
            str += strings[i];
        }
    }
    Console.Write(str);
}


//Печатаем массив
/*
void PrintArray(string[] array)
{

}
*/

string strings = "0iuyu54y66yiu5y6y5y65iuy6u49123";
//int size = 10;
//string[] array = CreateArray(size);
//FillArray(array);

Console.Write("Текст: ");
SortArray(strings);
//PrintArray(array);

Console.WriteLine();
Console.WriteLine();

//char symbol = 'j';
//System.Console.WriteLine((int)'0');
//System.Console.WriteLine((int)'z');
//bool flag = symbol >= '0' && symbol <= '9'; //условие отделения числа от символа
//System.Console.WriteLine($"flag: {flag}");


/*
string strings1 = "0iuyu54y66yiu5y6y5y65iuy6u49123";
string str = "";
int count = 0;
int countText = 0;


for (int i = 0; i < strings1.Length; i++)
{
    if (strings1[i] >= '0' && strings1[i] <= '9')
    {
        count++;
    }
    else
    {
        str += strings1[i];
        countText += 1;
    }
}
Console.Write("Кол-во цифр: ");
Console.WriteLine(count);

Console.Write("Кол-во букв: ");
Console.WriteLine(countText);
Console.Write("Текст: ");
Console.Write(str);
*/


// обьединение в одну строку
//char[] chararray = { 'h', 'i', 'g', 'h', 'l', 'o', 'a', 'd'}; //символьный массив
//            string str = new string(chararray); // объединение символов в строковую переменную 
//            Console.WriteLine(str); //строковый литерал
