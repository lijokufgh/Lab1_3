Console.WriteLine("Введите коардинаты крайних точек первого параллелограмма:");

double[] pointx = new double[4]; // Массив для всех значений х первой фигуры.
double[] pointy = new double[4]; // Массив для всех значений у первой фигуры.

double[] poinx = new double[4]; // Массив для всех значений х вторй фигуры.
double[] poiny = new double[4]; // Массив для всех значений у вторй фигуры.
for (int i = 0; i < 4; i++) // Заполнения коардинат первой фигуры.
{
    pointx[i] = double.Parse(Console.ReadLine());
    pointy[i] = double.Parse(Console.ReadLine());
}

// Просчёт длин сторон фигуры.
double a, b, c, d;
a = Math.Sqrt(Math.Pow(pointx[1] - pointx[0], 2) + Math.Pow(pointy[1] - pointy[0], 2));
b = Math.Sqrt(Math.Pow(pointx[2] - pointx[1], 2) + Math.Pow(pointy[2] - pointy[1], 2));
c = Math.Sqrt(Math.Pow(pointx[3] - pointx[2], 2) + Math.Pow(pointy[3] - pointy[2], 2));
d = Math.Sqrt(Math.Pow(pointx[0] - pointx[3], 2) + Math.Pow(pointy[0] - pointy[3], 2));

// Проверка на то что фигура паралелограмм.
if (a == b && c == d || a == 0 || c == 0 || b == 0 || d == 0)
{
    Console.WriteLine("Не параллелограмм!!!");
    Environment.Exit(0);
}
else if (a == c || b == d)
{
    Console.WriteLine("Параллелограмм!!!");
}
else
{
    Console.WriteLine("Не параллелограмм!!!");
    Environment.Exit(0);
}

Console.WriteLine(" \n Введите коардинаты крайних точек второго параллелограмма:");

for (int i = 0; i < 4; i++) // Заполнения коардинат второй фигуры.
{
    poinx[i] = double.Parse(Console.ReadLine());
    poiny[i] = double.Parse(Console.ReadLine());
}

// Просчёт длин сторон фигуры.
double h, e, l, p;
h = Math.Sqrt(Math.Pow(poinx[1] - poinx[0], 2) + Math.Pow(poiny[1] - poiny[0], 2));
e = Math.Sqrt(Math.Pow(poinx[2] - poinx[1], 2) + Math.Pow(poiny[2] - poiny[1], 2));
l = Math.Sqrt(Math.Pow(poinx[3] - poinx[2], 2) + Math.Pow(poiny[3] - poiny[2], 2));
p = Math.Sqrt(Math.Pow(poinx[0] - poinx[3], 2) + Math.Pow(poiny[0] - poiny[3], 2));

// Проверка на то что фигура паралелограмм.
if (h == e && l == p || h == 0 || l == 0 || e == 0 || p == 0)
{
    Console.WriteLine("Не параллелограмм!!!");
    Environment.Exit(0);
}
else if (h == l || e == p)
{
    Console.WriteLine("Параллелограмм!!!");
}
else
{
    Console.WriteLine("Не параллелограмм!!!");
    Environment.Exit(0);
}

// Проверка - накладываеться ли одна фигура на другую.
if (pointx[0] >= poinx[0] && pointx[0] <= poinx[1] && pointy[0] >= poiny[0] && pointy[0] <= poiny[1] || pointx[1] >= poinx[0] && pointx[0] <= poinx[2] && pointy[1] >= poiny[0] && pointy[0] <= poiny[2] || pointx[2] >= poinx[0] && pointx[0] <= poinx[3] && pointy[2] >= poiny[0] && pointy[0] <= poiny[3] || pointx[3] >= poinx[0] && pointx[0] <= poinx[0] && pointy[3] >= poiny[0] && pointy[0] <= poiny[0])
{
    Console.WriteLine("Наложение!!!");
    Environment.Exit(0);
}

if (pointx[0] >= poinx[1] && pointx[1] <= poinx[1] && pointy[0] >= poiny[1] && pointy[1] <= poiny[1] || pointx[1] >= poinx[1] && pointx[1] <= poinx[2] && pointy[1] >= poiny[1] && pointy[1] <= poiny[2] || pointx[2] >= poinx[1] && pointx[1] <= poinx[3] && pointy[2] >= poiny[1] && pointy[1] <= poiny[3] || pointx[3] >= poinx[1] && pointx[1] <= poinx[0] && pointy[3] >= poiny[1] && pointy[1] <= poiny[0])
{
    Console.WriteLine("Наложение!!!");
    Environment.Exit(0);
}

if (pointx[0] >= poinx[2] && pointx[2] <= poinx[1] && pointy[0] >= poiny[2] && pointy[2] <= poiny[1] || pointx[1] >= poinx[2] && pointx[2] <= poinx[2] && pointy[1] >= poiny[2] && pointy[2] <= poiny[2] || pointx[2] >= poinx[2] && pointx[2] <= poinx[3] && pointy[2] >= poiny[2] && pointy[2] <= poiny[3] || pointx[3] >= poinx[2] && pointx[2] <= poinx[0] && pointy[3] >= poiny[2] && pointy[2] <= poiny[0])
{
    Console.WriteLine("Наложение!!!");
    Environment.Exit(0);
}

if (pointx[0] >= poinx[3] && pointx[3] <= poinx[1] && pointy[0] >= poiny[3] && pointy[3] <= poiny[1] || pointx[1] >= poinx[3] && pointx[3] <= poinx[2] && pointy[1] >= poiny[3] && pointy[3] <= poiny[2] || pointx[2] >= poinx[3] && pointx[3] <= poinx[3] && pointy[2] >= poiny[3] && pointy[3] <= poiny[3] || pointx[3] >= poinx[3] && pointx[3] <= poinx[0] && pointy[3] >= poiny[3] && pointy[3] <= poiny[0])
{
    Console.WriteLine("Наложение!!!");
    Environment.Exit(0);
}

Console.WriteLine("Наложение нет!!!");