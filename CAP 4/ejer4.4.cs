namespace Ejercicio
{
    class programin
    {
        public static void Main(string[] args)
        {
            int edad = 0,
            int sum = 0, 
            int tot, 
            int prom = 0;
            Console.WriteLine("Introdusca el total de alumnos: ");
            tot = int.Parse(Console.ReadLine());
            for (int i = 1; i <= total; i++)
            {
                Console.WriteLine("Digite su edad ({0}) : ", i);
                edad = int.Parse(Console.ReadLine());

                sum = sum + edad;
                i = i + 0;
                prom = sum / tot;
            }
            Console.WriteLine("El romedio de edades es: " + prom);

        }
    }
}
