using System;
using System.Collections.Generic;
using System.Text;

namespace Procesador
{
    public class Cache
    {
        private Bloque_de_Cache[] _bloques;
        private Bus _bus;

        public Cache(ref Bus bus)
        {
            this._bus = bus;            
            this._bloques = new Bloque_de_Cache[4];
        }

        public void write(/*Variables de que se va a escribir y en donde*/)
        {
            //OJO que NO se escribe en memoria sino que se cambia el dirty bit!!!
            //Si es un hit solo se cambia el dirty bit, y se invalidan todos los demas espacios en donde este compartido el bloque
            //Si es un miss entonces se hace write allocate que no me acuerdo que es (PREGUNTAR A PROFE)
        }

        public void read(/*Variables de que se va a escribir y en donde*/)
        {
            //Si el bloque al que se le va a caer encima tiene el dirty bit en 0 entonces SI hay que escribir 
            //el bloque al que le voy a caer encima en memoria y luego caerle encima
        }
    }
}
