/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
меньше либо равна 3 символам
*/

void setArray (string [] SourseArray)
{   
    Console.WriteLine();
    Console.WriteLine("------------------Исходный массив--------------------");
    Console.Write("[");
    int n = 0;
    for (int i = 0; i < SourseArray.Length; i++)
    {
        Console.Write($"{SourseArray[i]} ");
        if (SourseArray[i].Length < 4)
        {
            n+=1;
        }
    }
    Console.WriteLine("]");
    string [] ArrayB = new string [n];
    Console.WriteLine();
    Console.WriteLine("---------------Отсортированный массив-----------------");
    Console.Write("[");
    int ArrayNumber=0;
    for (int i = 0; i < SourseArray.Length; i++)
    {
        if (SourseArray[i].Length < 4)
        {
            ArrayB[ArrayNumber]=SourseArray[i];
            Console.Write($"{ArrayB[ArrayNumber]} ");
            ArrayNumber+=1;
        }
    }
    Console.Write("]");
}

Console.WriteLine ("Введите номер примера (1 - 3): "); 
int userNumber1 = Convert.ToInt32 (Console.ReadLine());
if (userNumber1 == 1)
{
    string [] ArraySourse =  {"Hello", "2", "World", "-:)"};
    setArray (ArraySourse);
}
if (userNumber1 == 2)
{
    string [] ArraySourse =  {"1234", "1567", "-2", "computer"};
    setArray (ArraySourse);
}
if (userNumber1 == 3)
{
    string [] ArraySourse =  {"Russia", "Denmark", "Kazan"};
    setArray (ArraySourse);
}