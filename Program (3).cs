
Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());
int t=n;
int rev=0;
int Palindrome()
{
    while (n>0 || n<0)
{
   rev = rev * 10 + n % 10;
    n = n / 10;
}
Console.WriteLine(rev);
return rev;
}

Palindrome();
if (t==rev)
Console.WriteLine("is Palindrome");
else
Console.WriteLine("not Palindrome");



 


