using System;
using System.Collections.Generic;
using System.Text;

namespace Procesador
{
    class cacheDatos
    {
        private int[,] bloques;
        busDatos bus;

        public cacheDatos(busDatos b)
        {
            bus = b;

            bloques = new int[4, 19];
            //Inicializamos los bloques la caché. Tienen 20 bits y no 16 porque el bit 17 es el de la etiqueta, el 18 
            //es el que indica si el bloque es compartido o no, el bit 19 es el bit de validez y el 20 es el bit de suciedad.

            //bit compartido:
            //Está en 1 si el bloque esta compartido (está en más de una caché a la vez)
            //Está en 0 sino

            //bit de validez: 
            //Está en 1 si el bloque contiene la misma informacion que está en memoria (si otro bloque no 
            //tiene los mismos datos y ha escrito en ellos)

            //Está en 0 si no es válido (si los datos están modificados en otro bloque = si el otro bloque 
            //tiene el bit de suciedad en 1)

        }

        public void write(/*Variables de que se va a escribir y en donde*/)
        {
            //OJO que NO se escribe en memoria sino que se cambia el dirty bit!!!
            //Si es un hit solo se cambia el dirty bit, y se invalidan todos los demas espacios en donde este compartido el bloque
            //Si es un miss entonces se hace write allocate que no me acuerdo que es (PREGUNTAR A PROFE)
        }

        public int[] read(/*Variables de que se va a escribir y en donde*/)
        {
            int[] respuesta;
            respuesta = null;
            return respuesta;
            //Si el bloque al que se le va a caer encima tiene el dirty bit en 0 entonces SI hay que escribir 
            //el bloque al que le voy a caer encima en memoria y luego caerle encima
        }
    }
}
