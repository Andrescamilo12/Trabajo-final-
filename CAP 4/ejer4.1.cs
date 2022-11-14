namespace Ejercicio
{
    class programin
    {
        static void Main()
        {
            int a = 1;
            int final = 0;
            
            while (a <= 10)
            
            {
                Console.WriteLine("Introdusca un numero ({0})", a);
                int cant = Convert.ToInt32(Console.ReadLine());

                final = final + cant;
                i++;

                Console.WriteLine("la suma actual de los numeros es: {0}", final);
            }
        }
    }
}
