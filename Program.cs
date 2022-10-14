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


// Заполняем массив
void FillArray(string[] array)
{

}


// Сортируем массив
void SortArray(string[] array)
{

}


//Печатаем массив
void PrintArray(string[] array)
{

}


int size = 10;
string[] array = CreateArray(size);
FillArray(array);
SortArray(array);
PrintArray(array);
*/

char symbol = 'j';
System.Console.WriteLine((int)'a');
System.Console.WriteLine((int)'z');
bool flag = symbol >= '0' && symbol <= '9'; //условие отделения числа от символа
System.Console.WriteLine($"flag: {flag}");

/*
System.Console.WriteLine((char)122);

string[] strings = {"dfgb645dg. dghbfg 44555"};
foreach (var item in strings)
{
    System.Console.WriteLine(item);
}
*/

http://forum.codenet.ru/q72082/%D0%9A%D0%B0%D0%BA++%D0%B2%D1%8B%D0%B4%D0%B5%D0%BB%D0%B8%D1%82%D1%8C++%D1%87%D0%B8%D1%81%D0%BB%D0%B0++%D0%B8%D0%B7++%D1%81%D1%82%D1%80%D0%BE%D0%BA%D0%B8+%3F?s=0#answer_375452

string strings = "0iuyu54y66yiu5y6y5y65iuy6u49";
//int k = 0;
//string[] text = new string[count];
int count = 0;
for (int i = 0; i < strings.Length; i++)
{
    //if (Convert.ToInt32(strings[i]) >= 48 && Convert.ToInt32(strings[i]) <= 57)
    if (strings[i] >= '0' && strings[i] <= '9')
    {
        if (true)
        {
            count += strings[i];
            Console.WriteLine("Длина: ", count);
        }
    }
}
/*
for (int i = 0; i < strings.Length; i++)
{
    if (symbol >= '0' && symbol <= '9')
    {
       text[k] = strings[i];
    }
}
for (int i = 0; i < text.Length; i++)
{
    Console.WriteLine(text[k]);
}
*/


// обьединение в одну строку
//char[] chararray = { 'h', 'i', 'g', 'h', 'l', 'o', 'a', 'd'}; //символьный массив
//            string str = new string(chararray); // объединение символов в строковую переменную 
//            Console.WriteLine(str); //строковый литерал
