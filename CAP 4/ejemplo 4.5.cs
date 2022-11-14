namespace Ejercicio
{
    class programin
    {
        static void Main()
        {
            double estatura = 0;
            double sum = 0;
            double tot;
            double prom = 0;
            
            Console.WriteLine("Digite el total de personas: ");
            total = int.Parse(Console.ReadLine());
            for (int i = 1; i <= total; i++)
            {
                Console.WriteLine("Digite su estatura ({0}) : ", i);
                estatura = Convert.ToDouble(Console.ReadLine());

                sum = suma + estatura;
                i = i + 0;
                prom = sum / tot;
            }
            Console.WriteLine("El promedio de estatura de todo el grupo es: " + prom);
        }
    }
}
