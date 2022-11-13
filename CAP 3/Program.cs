namespace Ejercicios1
{
    public class program
    {
        public static void Main()
        {
            int numero;
            int resultado;
            int doblado;

            Console.WriteLine(" Por favor ingrese un numero ");
            numero = Convert.ToInt32(Console.ReadLine());
            doblado = numero * 2;
            resultado = doblado * 25;
            Console.WriteLine($"el numero doblado es: {doblado}");
            Console.WriteLine($"El resultado de la operacion es: {resultado}");
        }
    }
}
