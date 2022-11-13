namespace ejercicio
{
     class programin

    {
        static void Main(string[] args)
        {

            double valor, uni_cantidad, final, preciobruto ;
            double Iva = 0.12, limite = 50000, descuento = 0.05;

            
            Console.WriteLine("Introdusca el precio de su compra");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Introdusca las unidades de su compra");
            uni_cantidad = double.Parse(Console.ReadLine());
            preciobruto = (uni_cantidad * valor) + ((uni_cantidad * valor) * (Iva));
            if (preciobruto > limite)
            {
                double descuentofinal;
                descuentofinal = (preciobruto) - (preciobruto * descuento);
                Console.WriteLine("el precio final con descuento es de: " + final);

            }
            if (preciobruto <= limite)
            {
                Console.WriteLine("El precio final es de: " + preciobruto);
            }


        }

    }



}
