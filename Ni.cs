//Ichi 1
int a = int.Parse(Console.ReadLine());
if (a%3 == 0)
{
    Console.WriteLine("TAK");
}
else
{
    Console.WriteLine("NIE");
}
//Ni 2
int a = int.Parse(Console.ReadLine());
if(100 <= a && a <= 999)
{
    Console.WriteLine("Jest trzy cyfrowa");
}
else
{
    Console.WriteLine("Nie jest tzycefrowa");
}
if(a%17 == 0)
{
    Console.WriteLine("Podzielna przez 17");
}
else
{
    Console.WriteLine("Nie jest podzielna przez 17");
}
//San 3
int a = int.Parse(Console.ReadLine());
if (a >= 18)
{
    Console.WriteLine("Jesteś pełnoletni");
}
else
{
    Console.WriteLine("Jesteś nie pełnoletni");
}
//Yon 4
Console.WriteLine("Podaj ciężar w tonach i dostaniesz odpowiedż, czy możesz przyjechać.");
int a = int.Parse(Console.ReadLine());
if (a > 20)
{
    Console.WriteLine("NIE");
}
else
{
    Console.WriteLine("TAK");
}
