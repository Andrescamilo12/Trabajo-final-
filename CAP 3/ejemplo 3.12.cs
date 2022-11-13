namespace ejercicio
{
    class programin
    {
        static void Main()
        {
            int cant_citas;
            double costo;

            Console.WriteLine("Digite la cantidad de citas");
            cant_citas = Convert.ToInt32(Console.ReadLine());

            if (cant_citas <= 3)
            {
                costo = (cant_citas * 200000);
                Console.WriteLine("Cada cita cuesta 200.000");
                Console.WriteLine("el gasto del tratamiento es: " + costo);
            }
            if (cant_citas >= 4 && cant_citas <= 5)
            {
                costo = (cant_citas * 150000) + 600000;
                Console.WriteLine("el cosot de la cita es 150.000");
                Console.WriteLine("el gasto del tratamiento es: " + costo);
            }
            if (cant_citas >= 6 && cant_citas <= 8)
            {
                costo = (cant_citas * 100000) + 900000;
                Console.WriteLine("cada cita cuesta 100.000");
                Console.WriteLine("el gasto del tratamiento es: " + costo);
            }
            if (cant_citas > 8)
            {
                costo = (cant_citas * 50000) + 1200000;
                Console.WriteLine("Cada cita cuesta 50.000");
                Console.WriteLine("el gasto del tratamiento es: " + costo);
            }
        }

    }

}
