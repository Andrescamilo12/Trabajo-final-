
namespace Ejercicio
{
     class programin
    {
        static void Main()
        {
            float nume;
            Console.Write("escriba numero: ");
            nume = float.Parse(Console.ReadLine());
            if (nume == 0)
            {
                Console.Write("numero digitado {0} es cero", nume);
            }
            if (nume > 0)
            {
                Console.Write("numero {0} es positivo", nume);
            }
            if (nume < 0)
            {
                Console.Write("numero {0} es negativo", nume);
            }
            Console.ReadKey();
        }
    }
}
