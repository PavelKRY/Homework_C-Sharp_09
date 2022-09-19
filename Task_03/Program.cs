// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Akkerman(int m,int n)
{
    if(m==0)
    {
        return n+1;
    }
    if(m>0&&n==0)
    {
        return  Akkerman(m-1,1);
    }
    if(m>0&&n>0)
    {
        return  Akkerman(m-1,Akkerman(m,n-1));
    }
    return n;
}
int m=4;
int n=1;
int result = Akkerman(m,n);
Console.WriteLine(result);