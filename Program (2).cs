Console.WriteLine("Input X1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double Vector()
{
double res=Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)),2);
return res;
}

Console.WriteLine("Distance="+Vector());