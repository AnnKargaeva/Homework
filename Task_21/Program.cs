double[] A = new double[] {3, 6, 8};
double[] B = new double[] {2, 1, -7};

double ans = Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2) + Math.Pow(A[2] - B[2], 2));

Console.WriteLine ($"Растояние между А и В = {Math.Round(ans, 2)}");