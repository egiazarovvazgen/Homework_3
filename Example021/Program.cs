// Программа, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D-пространстве

double distance(int[] dotsA, int[] dotsB, int[] dotsC)
{
    return Math.Sqrt(Math.Pow(dotsA[1] - dotsA[0], 2) + Math.Pow(dotsB[1] - dotsB[0], 2) + Math.Pow(dotsC[1] - dotsC[0], 2));
}

int[] dotsA = new int[2];
int[] dotsB = new int[2];
int[] dotsC = new int[2];

Console.WriteLine("Введите X(A): ");
dotsA[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Y(A): ");
dotsA[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите X(B): ");
dotsB[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Y(B): ");
dotsB[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите X(C): ");
dotsC[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Y(C): ");
dotsC[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Round(distance(dotsA, dotsB, dotsC), 2));