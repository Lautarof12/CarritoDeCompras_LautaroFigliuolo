using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Collections;

namespace Desafio_carrito_de_compras
{
    class Program
    {
        static void Main(string[] args)
        {
            int accion;
            ArrayList stock = new ArrayList();
            int cantidad = 0;
            double precio;
            double descuento = 0;
            double precioFinal = 0;
            int opcion;




            Console.WriteLine("SHOPPING ONLINE DE CAMISAS - Ventas minoristas y mayoristas");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("MENU PRINCIPAL");



            do
            {

                Console.WriteLine("1- Añadir camisas al carrito de compras");
                Console.WriteLine("2- Eliminar camisas del carrito de compras");
                Console.WriteLine("3- Salir");
                accion = Convert.ToInt32(Console.ReadLine());
                if (accion == 1)
                {
                    stock.Add("Camisa");

                }
                if (accion == 2)
                {
                    stock.RemoveAt(0);
                }
                Console.WriteLine("------------------------------------------------------------");
                cantidad = stock.Count;
                Console.WriteLine("          - Cantidad de camisas en el carrito de compras: " + cantidad);
                Console.WriteLine("          - Precio unitario $1000");
                precio = cantidad * 1000;
                Console.WriteLine("          - Precio total sin descuento: $" + precio);
                if (cantidad >= 3 && cantidad <= 5)
                {
                    descuento = 10;
                }
                if (cantidad < 3)
                {
                    descuento = 0;
                }
                if (cantidad > 5)
                {
                    descuento = 20;
                }
                Console.WriteLine("          - Tipo de descuento aplicado: " + descuento + "%");
                if (descuento == 10)
                {
                    precioFinal = precio - (precio * 0.10);
                }
                if (descuento == 20)
                {
                    precioFinal = precio - (precio * 0.20);
                }
                Console.WriteLine("          - Precio final con descuento: $" + precioFinal);
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("PRESIONE ENTER PARA CONTINUAR");
                Console.ReadKey();
                Console.Clear();


            } while (accion != 3);
            Console.Clear();
            Console.WriteLine("Esta seguro que desea salir?");
            Console.WriteLine("Para salir presione 1, para volver al inicio presione 2");
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("GRACIAS POR UTILIZAR NUESTRO PROGRAMA");
                Console.WriteLine("PRESIONE ENTER PARA CERRAR");

            }
               
          

            Console.ReadKey();
        }
    }
}
