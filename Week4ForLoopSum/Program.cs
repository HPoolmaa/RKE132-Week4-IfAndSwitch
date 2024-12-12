using System.Diagnostics.CodeAnalysis;

for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"i (n+1) = {i}");
}
Console.WriteLine("end 1");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i (n+1) = {i+1}");
}
Console.WriteLine("end 2");

int sum = 1;
for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"i = {i}");
    if (i == 0)
    {
        Console.WriteLine($"Current total: {sum}");
    }
    else
    {
        Console.WriteLine($"Current total: {sum}");
    }
    sum = sum + i; 
}
Console.WriteLine($"Final total: {sum}");
Console.WriteLine("end 3");

int sum2 = 0;
for (int i = 1; i < 3; i++)
{
    Console.WriteLine($"i = {i}");
    sum2 = sum2 + i;
}
Console.WriteLine($"Final total: {sum2}");
Console.WriteLine("end 4");