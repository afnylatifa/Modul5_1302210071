
using System.Collections.Specialized;

class penjumlahan
{
    public void JumlahTigaAngka<T>(T satu, T dua, T tiga)
    {
        dynamic wan, tu, tri;
        wan = satu;
        tu = dua;
        tri = tiga;
        dynamic jumlah = wan + tu + tri;
        Console.WriteLine(jumlah.ToString());
    }
}

class program
{
    static void Main(string[] args)
    {
        penjumlahan jumlah = new penjumlahan();
        jumlah.JumlahTigaAngka<float>(13, 02, 21);
    }
}