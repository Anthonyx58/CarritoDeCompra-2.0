using System;
using System.Linq;
using CapaNegocios;


namespace CarritoDeCompras
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            GestionProductos producto = new GestionProductos();
            Console.WriteLine(producto.ListarProductos());

            //1) La cantidad total de todos los productos.
            Console.WriteLine("1.La cantidad de existencias totales son ");
            Console.WriteLine(producto.Existencias());
            Console.WriteLine("");
            //2) La suma de todos los precios de los productos para conocer el valor del inventario.
            Console.WriteLine("2.La suma de los precios son ");
            Console.WriteLine(producto.PrecioTot());
            Console.WriteLine("");
            //3) Listado de productos menores a un valor proporcionado y ordenarlos alfabeticamente de A a Z. 
            Console.WriteLine("Menor Precios");
            Console.WriteLine(producto.MenorPrecio());
            Console.WriteLine("");


            //4) Los productos ordenados por categoria y por precio de mayor a menor. (2 Puntos)
            Console.WriteLine("4.Productos de mayor a menor");
            Console.WriteLine(producto.MayorMenor());
            //Console.WriteLine(producto.Precios());

            //5) Los productos ordenados alfabeticamente de A a Z. (1 Puntos)*/
            Console.WriteLine("5.Productos ordenados de la A a la Z por categoria  ");
            Console.WriteLine(producto.OrdenarAlf());



        }



        /* GRUPO 3
            Utilizando expresiones lambda o linq cree los métodos en las capas respectivas que permitan mostrar por pantalla:
            1) La cantidad total de todos los productos. (2 Puntos)
            
            2) La suma de todos los precios de los productos para conocer el valor del inventario. (1 Puntos)

            3) Listado de productos menores a un valor proporcionado y ordenarlos alfabeticamente de A a Z. (2 Puntos)

            4) Los productos ordenados por categoria y por precio de mayor a menor. (2 Puntos)

            5) Los productos ordenados alfabeticamente de A a Z. (1 Puntos)*/
             
        
    }

}
