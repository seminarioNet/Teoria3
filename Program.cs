﻿double[]? vector = new double[10];
Procesar(null, 1, 1);
Procesar(vector, 10, 1);
Procesar(vector, -1, 1);
Procesar(vector, 1, -10);
Procesar(vector, 1, 1);

void Procesar(double[]? v, int i, int c)
{
    c = c + 10;
    v[i] = 1000 / c;
    Console.WriteLine(v[i]);
}
