//--------------------------------------------------------------------------------
// <copyright file="Train.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace ClassLibrary
{
    /// <summary>
    /// Esta clase representa un tren muy básico.
    /// </summary>
    public class Train
    {
        /// <summary>
        /// Obtiene un valor que indica si las maquinas del tren han sido encendidas o no.
        /// </summary>
        /// <value><c>true</c> si las máquinas fueron encendidas, <c>false</c> en caso contrario.</value>
        public bool IsEngineStarted { get; private set; }

        private static int count = 0;
        /// <summary>
        /// Obtiene la cantidad de instancias de la clase Train existentes durante la ejecución.
        /// </summary>
        public static int Count { get => count; set => count = value; }

        private string id;
        /// <summary>
        /// Cadena de caracteres que identifica a una instancia de Train en específico.
        /// </summary>
        /// <value>Retorna el valor del string identificador de una instancia de la clase Train</value>
        public string Id { get; set; }

        /// <summary>
        /// Constructor para una instancia de la clase Train. Recibe un string identificador como parámetro.
        /// </summary>
        public Train(string id){
            this.Id = id;
            Train.count++;
        }

        ~Train(){
            Train.count--;
        }

        /// <summary>
        /// Enciende las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser encendidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running");
                return false;
            }
        
            this.IsEngineStarted = true;
            Console.Write("Engines on");
            return true;
        }

        /// <summary>
        /// Detiene las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser detenidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsEngineStarted;
        }
    }
}