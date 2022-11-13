namespace Ejercicios2
{
    public class program
    {

        public static void Main()
        {

            int num1;
            int num2;
            int num3;
            int num4;
            double producto;
            double suma;
            double md;
            Console.WriteLine("escriba 4 variables");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            producto = num1 * num2 * num3 * num4;
            suma = num1 + num2 + num3 + num4;
            md = suma / 4;
            Console.WriteLine("el producto es:" + producto);
            Console.WriteLine("la suma es:" + suma);
            Console.WriteLine("la media es:" + md);
        }

    }

}
