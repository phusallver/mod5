using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Penjumlahan TT = new Penjumlahan();
        Console.Write("Masukkan bilangan pertama :");
        float bill1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan bilangan kedua :");
        float bill2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan bilangan ketiga :");
        float bill3 = Convert.ToInt32(Console.ReadLine());
        TT.JumlahTigaAngka<float>(bill1, bill2, bill3);
    }
    public class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T bil1, T bil2, T bil3)
        {
            T hasilJumlah;
            hasilJumlah = (dynamic)bil1 + (dynamic)bil2 + (dynamic)bil3;
            Console.WriteLine("Hasil dari penjumlahan" +
                bil1 + " + " + bil2 + " + " + bil3 + " yaitu " +
                hasilJumlah);
        }
    }
}