int a1 = 2;
int a2 = 8;
int a3 = 5;
int a4 = 1;
int a5 = 6;

int max = a1;

if (a2 > max) max = a2;
if (a3 > max) max = a3;
if (a4 > max) max = a4;
if (a5 > max) max = a5;

Console.WriteLine("max = " + max);