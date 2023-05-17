// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double x1 = Prompt("Введите координату X первой точки-");
double y1 = Prompt("Введите координату y первой точки-");
double z1 = Prompt("Введите координату z первой точки-");
double x2 = Prompt("Введите координату X второй точки-");
double y2 = Prompt("Введите координату y второй точки-");
double z2 = Prompt("Введите координату z второй точки-");

double Prompt(string message)
{
    Console.Write(message);
    double coordNumber = double.Parse(Console.ReadLine()!);
    return coordNumber;
}

Match(x1, y1, x2, y2, z1, z2);

void Match(double x1, double y1, double x2, double y2, double z1, double z2)
{
double A = (Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+(Math.Pow((z2-z1),2))));
Console.WriteLine($"Расстояние между точкой А с координатамми {x1};{y1};{z1} и точкой B с координатами {x2};{y2};{z2} равно {A}");
}