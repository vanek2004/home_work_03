// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите коордиинаты двух точек в 3D пространстве:");
Console.Write("x1 --> ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 --> ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 --> ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2 --> ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 --> ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 --> ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance (int xA, int yA, int zA, int xB, int yB, int zB){
    int first = xB - xA;
    int second = yB - yA;
    int last = zB - zA; 
    double result = Math.Sqrt(Math.Pow(first, 2)+Math.Pow(second, 2)+Math.Pow(last, 2));
    return result;
}           
double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между двумя точками в 3D пространстве --> {distance}");
