double wynik = 0;

for (int i = 1; i <= 20; i++)
{
    double potega = Math.Pow(i, 2);
    potega = potega * i;
    Console.WriteLine($"liczba {i} do potegi trzeciej to: {potega}");

}