//4. Detreminati daca un an y este an bisect
int y=int.Parse(Console.ReadLine());

if((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
{
    Console.WriteLine($"{y} este an bisect");
}
else
{
    Console.WriteLine($"{y} nu este an bisect");
}