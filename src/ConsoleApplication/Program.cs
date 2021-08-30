//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            // CrearDiezMillones()
            // CompararTrenes()
            CompararTrenes();
        }

        /// <summary>
        /// Método para crear 10.000.000 de instancias de la clase Train.
        /// Al intentar crearlas, el runtime identifica un sobreconsumo o agotamiento
        /// de memoria cuando me acerco a 30.000, por lo que destruye a las instancias 
        /// existentes.
        /// </summary>
        static void CrearDiezMillones(){
            for(int i = 0;i < 10000000; i++){
                Train tren = new Train("a");
                System.Console.WriteLine(Train.Count);
            }
        }

        /// <summary>
        /// Método para comparar trenes.
        /// Al comparar diferentes trenes creados con el constructor de la clase Train,
        /// nos encontramos con que todas las comparaciones resultan en false.
        /// Esto se debe a que las referencias a los objetos guardadas en las variables
        /// t1, t2 y t3 apuntan a distintas partes del heap o montículo. A pesar de que
        /// las id de t1 y t2 coinciden, no son el mismo objeto.
        /// </summary>
        static void CompararTrenes(){
            Train t1 = new Train("Last Train to London");
            Train t2 = new Train("Last Train to London");
            Train t3 = new Train("Runaway Train");
            System.Console.WriteLine(t1 == t2);
            System.Console.WriteLine(t2 == t3);
        }
    }
}