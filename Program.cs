Console.WriteLine("Input any number");
int num = Convert.ToInt32(Console.ReadLine());
void Cubed()
{
for (int i=1;i<=num;i++)
{
    Console.WriteLine(i+"^3="+Math.Pow(i,3));
}
}
Cubed();
