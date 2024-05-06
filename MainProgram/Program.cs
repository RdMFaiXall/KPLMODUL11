using MatematikaLibraries;

// deklarasi class bernama Program
class Program
{
    // deklarasi Main sebagai program utama
    public static void Main(string[] args)
    {
        // deklarasi variabel/object bernama Matematika untuk memanggil class MathLogic
        MathLogic Matematika = new MathLogic();

        // memanggil method FPB
        Console.WriteLine("FPB");
        Console.WriteLine("Input : {60, 45}");
        Console.WriteLine("Output : " + Matematika.FPB(60, 45));
        Console.WriteLine("");

        // memanggil method KPK
        Console.WriteLine("KPK");
        Console.WriteLine("Input : {12, 8}");
        Matematika.KPK(12, 8);
        Console.WriteLine("");

        // memanggil method Turunan
        Console.WriteLine("Turunan");
        Console.WriteLine("Input : [1 ,4, -12, 9]");
        Matematika.Turunan([1, 4, -12, 9]);
        Console.WriteLine("");

        // memanggil method Integral
        Console.WriteLine("Integral");
        Console.WriteLine("Input : [4 ,6, -12, 9]");
        Console.WriteLine("Output : " + Matematika.Integral([4, 6, -12, 9]));
    }
}