/*1.Используя готовый шаблонный класс Array и ранее разработанные классы объектов, 
 * напишите программу в которой в цикле создайте списки  объектов типа double, 
 * Student, Worker, Pencil, Cat  и затем распечатайте их на на экране.*/

/*на C# нет шаблонов, как и discriminated union. Близки только generic types (generics):*/
using System;
using System.Collections.Generic;

var list = new List<double>();
for (var i = 0; i < 10; i++)
{
    list.Add(i * 2.5);
}

Console.WriteLine(string.Join(Environment.NewLine, list));
/*List<T> - это массив динамического размера.*/