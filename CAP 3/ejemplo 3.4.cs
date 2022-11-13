namespace Ejercicio
{
    class programin
    {
        static void Main()
        {

            Console.WriteLine("Ingrese el precio de su traje");
            double cantidad;
            cantidad = Convert.ToDouble(Console.ReadLine());
            if (cantidad > 2500)
            {
                double descuento;
                descuento = cantidad - (cantidad * 0.15);
                Console.WriteLine("Su descuento es de: {0}", descuento);
            }
            else
            {
                double des;
                des = cantidad - (cantidad * 0.008);
                Console.WriteLine("El precio final con descuento del 15% es: {0}", des);

            }

        }

    }

}
