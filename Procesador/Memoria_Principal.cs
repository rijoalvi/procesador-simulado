using System;
using System.Collections.Generic;
using System.Text;

namespace Procesador
{
    class Memoria_Principal
    {
        private Bloque[] memoria;

        public Memoria_Principal()
        {
            memoria = new Bloque[32];
        }

        public void write(Bloque datos, int numero_de_bloque)
        {
            this.memoria[numero_de_bloque] = datos;
        }

        public void read(ref Bloque datos, int numero_de_bloque)
        {
            datos = this.memoria[numero_de_bloque];
        }

    }
}
