// Emir Can BULDU - 202213709015
int sayac = 0;
int oran = 0;
int[] anne = new int[10];
int[] baba = new int[10];
int[] cocuk = new int[10];
int[] capraz = new int[10];
int[] mutasyon = new int[10];
Random rnd = new Random();
int b=0;
for (int i = 0; i < cocuk.Length; i++)
{
    b++;
    Console.WriteLine($"Bireyin {b}.indeksine ait numarayı giriniz (sadece 1 veya 0)");
    cocuk[i] = int.Parse(Console.ReadLine());
    if (cocuk[i]>1 || cocuk[i]<0)
    {
        Console.WriteLine("Hatalı sayı girdiniz tekrar deneyin");
        b--;
        i--;
    }
}
while (oran !=10)
{
    oran = 0;
    sayac++;
    for (int i = 0; i < anne.Length; i++)
    {
        anne[i] = rnd.Next(0, 2);
        baba[i] = rnd.Next(0, 2);
    }
    for (int i = 0; i < capraz.Length / 2; i++)
    {
        capraz[i] = anne[i];
    }
    for (int i = 5; i < capraz.Length; i++)
    {
        capraz[i] = baba[i];
    }
    Array.Copy(capraz, mutasyon, 10);
    int indeks = rnd.Next(0, 10);
    if (mutasyon[indeks] == 1)
    {
        mutasyon[indeks] = 0;
    }
    else
    {
        mutasyon[indeks] = 1;
    }
    for (int i = 0; i < cocuk.Length; i++)
    {
        if (cocuk[i] == mutasyon[i])
        {
            oran++;
        }
    }
   
}
Console.WriteLine($"{sayac}.Deneme");
Console.Write("Anne : ");
foreach (var a in anne)
{
    Console.Write($"{a} ");
}
Console.Write("\nBaba : ");
foreach (var a in baba)
{
    Console.Write($"{a} ");
}
Console.Write("\nÇocuk : ");
foreach (var a in cocuk)
{
    Console.Write($"{a} ");
}
Console.Write("\nÇaprazlama : ");
foreach (var a in capraz)
{
    Console.Write($"{a} ");
}
Console.Write("\nMutasyon : ");
foreach (var a in mutasyon)
{
    Console.Write($"{a} ");
}
Console.WriteLine($"\nBenzerlik oranı : %{oran * 10}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"İstenen bireye {sayac}.denemede ulaştınız.");
Console.ReadLine();