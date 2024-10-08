using Shape;


Console.Write("Введите радиус окружности: "); Circle circle = new Circle(Convert.ToDouble(Console.ReadLine()));
Console.WriteLine("Площадь окружности: " + circle.GetArea() + "\nПериметр окружности: " + circle.GetPerimeter() + "\nДиаметр окружности: " + circle.GetDiameter());

Console.Write("Введите стороны прямоугольника: "); Square square = new Square(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
Console.WriteLine("Площадь прямоугольника: " + square.GetArea() + "\nПериметр прямоугольника: " + square.GetPerimeter());

Console.Write("Введите стороны треугольника: "); Triangle triangle = new Triangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
Console.WriteLine("Площадь треугольника: " + triangle.GetArea() + "\nПериметр треугольника: " + triangle.GetPerimeter());