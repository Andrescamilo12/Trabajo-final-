namespace Ejercicio
{
    class programin
    {
        static void Main()
        {

            double numero, final;

            Console.Write("Cantidad de lapicez: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero >= 1000)
            {
                final = numero * .85;
            }
            else
            {
                final = numero * .90;
            }
            Console.WriteLine("Lo que tiene que pagar por los lapicez es: $ " + final);

        }
    }
}
