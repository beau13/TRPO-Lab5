// See https://aka.ms/new-console-template for more information
using Laba3.ClassLibrary;


Console.WriteLine("Введите радиус вращения цилиндра:");
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите высоту цилиндра:");
double h = Convert.ToDouble(Console.ReadLine());

double result = new Cylinder_surface_area().Cylinder_surface_area_formula(r, h);
Console.WriteLine("Полученная площадь поверхности цилиндра: " + result);
