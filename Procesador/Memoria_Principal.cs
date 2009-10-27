using System;
using System.Collections.Generic;
using System.Text;

namespace Procesador
{
    public class Memoria_Principal
    {
        private Bloque[] _memoria;

        public Memoria_Principal()
        {
            _memoria = new Bloque[32];
        }

        public void write(Bloque datos, int numero_de_bloque)
        {
            this._memoria[numero_de_bloque] = datos;
        }

        public void read(ref Bloque datos, int numero_de_bloque)
        {
            datos = this._memoria[numero_de_bloque];
        }

    }
}
