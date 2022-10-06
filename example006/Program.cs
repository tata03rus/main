int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;
if (a > b)    max = a;
if (b>max)    max=b;
if (c>max) max=c;
if (d>max) max=d;
else
{
    max=e;
}
Console.Write(max);