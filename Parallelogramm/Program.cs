Console.WriteLine("Введите коардинаты крайних точек первого параллелограмма:");

double[] firstX = new double[4] { 1, 2, 6, 5 }; // Массив для всех значений х первой фигуры.
double[] firstY = new double[4] { 1, 3, 3, 1 }; // Массив для всех значений у первой фигуры.

//double[] secondX = new double[4] { 2, 3, 7, 6 }; // Массив для всех значений х вторй фигуры.
//double[] secondY = new double[4] { 2, 4, 4, 2 }; // Массив для всех значений у вторй фигуры.

double[] secondX = new double[4] { 3, 4, 8, 7 }; // Массив для всех значений х вторй фигуры.
double[] secondY = new double[4] { 4, 6, 6, 4 }; // Массив для всех значений у вторй фигуры.


void Phigur(double[] XY, double[] YX)
{
    int q = 1;
    double[] a = new double[4];
    for (int i = 0; i < 4; i++)
    {
        if (q == 4) q = 0;
        a[i] = Math.Sqrt(Math.Pow(XY[q] - XY[i], 2) + Math.Pow(YX[q] - YX[i], 2));
        q++;
    }


    // Проверка на то что фигура паралелограмм.
    if (a[0] == 0 || a[1] == 0 || a[2] == 0 || a[3] == 0)
    {
        Console.WriteLine("Не параллелограмм!!!");
        Environment.Exit(0);
    }
    else if (a[0] == a[2] || a[1] == a[3])
    {
        Console.WriteLine("Параллелограмм!!!");
    }
    else
    {
        Console.WriteLine("Не параллелограмм!!!");
        Environment.Exit(0);
    }
}
Phigur(firstX, firstY);
Console.WriteLine(" \nВведите коардинаты крайних точек второго параллелограмма:");
Phigur(secondX, secondY);


//for (int i = 0; i < 4; i++) // Заполнения коардинат первой фигуры.
//{
//    firstX[i] = double.Parse(Console.ReadLine());
//    firstY[i] = double.Parse(Console.ReadLine());
//}

//for (int i = 0; i < 4; i++) // Заполнения коардинат второй фигуры.
//{
//    secondX[i] = double.Parse(Console.ReadLine());
//    secondY[i] = double.Parse(Console.ReadLine());
//}

// Проверка - накладываеться ли одна фигура на другую.
int r = 1;
for (int i = 0; i < 4; i++)
{
    if (r == 4) r = 0;
    for (int j = 0; j < 4; j++)
    {
        if (firstX[j] >= secondX[i] && firstX[i] <= secondX[r] && firstY[j] >= secondY[i] && firstY[i] <= secondY[r])
        {
            Console.WriteLine("Наложение!!!");
            Environment.Exit(0);
        }        
    }
    r++;
}

Console.WriteLine("Наложение нет!!!");