namespace tp_modul11
{
    public static double[] RootsOf(double[] equ)
    {
        double a = equ[0];
        double b = equ[1];
        double c = equ[2];

        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            throw new Exception("Equation results in complex numbers");
        }
        double[] roots = new double[2];
        roots[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
        roots[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);

        return roots;

    }
    Public static double[] RootsSquared(double[] equ)
    {
        double x = equ[0];
        double y = equ[1];

        double[] rootsResult = new double[3];
        rootsResult[0] = x * x;
        rootsResult[1] = 2 * x * y;
        rootsResult[2] = y * y;

        return rootsResult;
    }
}
