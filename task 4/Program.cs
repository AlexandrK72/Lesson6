int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <=n; i++) result *= a;
    return result;
}
int PowerlRec(int a, int n)
{
    //return n == 0 ? 1 : PowerlRec(a, n-1) *a;
    if (n==0) return 1;
    else return PowerlRec(a, n-1) * a;
}

int PowerlRecMath(int a, int n)
{
    if (n==0) return 1;
    else if (n% 2 == 0) return PowerlRecMath(a*a, n/2);
    else return PowerlRec(a, n-1) * a;
}


Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerlRec(2, 10));
Console.WriteLine(PowerlRecMath(2, 10));