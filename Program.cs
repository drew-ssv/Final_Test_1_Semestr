// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.'"

Console.WriteLine("Финальное задание к 1 четверти");

Console.Write("Введите несколько строк разной длины для будущего массива: ");
string? input = Convert.ToString(Console.ReadLine()); 
if (input == string.Empty) // проверка отсутствия пустого ввода пользователем, при пустом массиве программа далее не идет
{
Console.WriteLine("Исходный массив, введенный пользователем: пуст");
}
else
{
string [] massive = input.Split(' ', ',', '.', ';'); //запись пользовательского ввода в массив строками с разделителем (с использованием Split)
NewMassiveOutput(massive);
PrintFirstMassive(massive);
}

void NewMassiveOutput (string [] massive) // метод перезаписывает в новый массив только те строки, которые, соответствуют условиям, задаваемым пользователем
{
     string[] changedMassive = new string[massive.Length];
     Console.Write("Введите цифрой макс кол-во символов в строках нового массива: ");
     int condition = Convert.ToInt16(Console.ReadLine());
     
     Console.WriteLine(); 
     Console.WriteLine($"Строки с кол-вом символов <= {condition} ");
     for (int i = 0; i < massive.Length; i ++)
     {      
        if(massive[i].Length <= condition) 
        {
        changedMassive[i] = massive[i];
        Console.WriteLine(changedMassive[i]); 
        }
     }
        Console.WriteLine(); 
}

void PrintFirstMassive(string [] massive) // метод для вывода в консоль изначального массива (если он не пуст)
  {
    Console.WriteLine("Начальный массив");
    for (int i=0; i<massive.Length; i++){
        Console.WriteLine(massive[i]);
  }
    Console.WriteLine();
}
