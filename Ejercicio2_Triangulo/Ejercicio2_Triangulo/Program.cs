public class Program
{
    private static void Main(string[] args)
    {
        double seg1, seg2, seg3, suma;
        bool IsTriangle;
        string msj;

        Console.Write("Ingrese el primer segmento: ");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo segmento: ");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer segmento: ");
        seg3 = Convert.ToDouble(Console.ReadLine());

        if ((seg1 + seg2) > seg3)
        {
            if ((seg2 + seg3) > seg1)
            {
                IsTriangle = true;
            }

            else
            {
                IsTriangle = false;
            }





        }
        else
        {
            IsTriangle = false;
        }

    }

}
