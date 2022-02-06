// See https://aka.ms/new-console-template for more information
using Classwork1_2txt; //без явного указания не работает программа, тк не видит другие классы

Console.WriteLine("Hello, Teacher!");

Point point1 = new Point(1, 2);
Point point2 = new Point(2, 3);
Point point3 = new Point(3, 4);
Point point4 = new Point(4, 5);

Console.WriteLine($"Количество экземпляров равно {Point.CountInstance}");

Console.WriteLine($"Расстояние между 1-й и 4-й точками равно {Point.LengthPoints(point1, point4)}");

