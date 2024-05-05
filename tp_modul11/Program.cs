using LibraryAlgebra;
internal class Program
{
    public static object LibraryAlgebra { get; private set; }

    private static void Main(string[] args)
    {
        Console.WriteLine("Mencari akar-akar....");
        double[] equation = { 5, -2, -16 };
        double[] roots = LibraryAlgebra.RootsOf(equation);
        Console.WriteLine($"Akar persamaan : {roots[0]} dan {roots[1]}");

        double[] anotherRoot = new double[2] { 5, 2, 16 };
        double[] rootsResult = LibraryAlgebra.RootsSquared(anotherRoot);
        Console.WriteLine($"Kuadrat persamaan: ({rootsResult[0]}x^2 + {rootsResult[1]}x + {rootsResult[2]})");
    }
}