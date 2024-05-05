using MatematikaLibraries;

class Program
{
    public static void Main(string[] args)
    {
        MathLogic Matematika = new MathLogic();
        Matematika.FPB(1, 2);
        Matematika.KPK(1, 2);
        /*Matematika.Turunan(1, 2);
        Matematika.Integral(1, 2);*/

        Console.WriteLine("");
    }
}