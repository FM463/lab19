/*2.Напишите функции-шаблоны  для : 
 *•удваивания значения объекта любого типов;
 *•обмена значений двух объектов любых типов;
 *•определения большего из значений двух объектов любых типов;
 *•сравнения значений двух объектов любых типов.*/

/*С выходом C# 11 и .NET 7 должны появиться статические абстрактные методы в интерфейсах 
 * и все примитивные типы как int, float, double и тд. должны будут их реализовывать. 
 * Сейчас эта фича доступна только в preview на .NET 6. Не используя preview фичу можно сделать так:*/
using System;
using System.Collections.Generic;

double a = 5, b = 6;
Swap(ref a, ref b);
Console.WriteLine((a, b));

Console.WriteLine(Double(a, x => x * 2));
Console.WriteLine(Max(a, b, (x, y) => x > y));
Console.WriteLine(Compare(a, b, Comparer<double>.Default));

static T Double<T>(T value, Func<T, T> calculateDouble)
    => calculateDouble(value);

static void Swap<T>(ref T left, ref T right)
    => (left, right) = (right, left);

static T Max<T>(T left, T right, Func<T, T, bool> findMax)
    => findMax(left, right) ? left : right;

static int Compare<T>(T left, T right, IComparer<T> comparer)
    => comparer.Compare(left, right);
