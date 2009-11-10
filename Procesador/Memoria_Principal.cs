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
            this._memoria = new Bloque[128];
            this.inicializar_memoria();
        }
        private void inicializar_memoria() 
        {
            for (int x = 0; x < 128; ++x ) 
            {
                Bloque vacio = new Bloque();
                this._memoria[x] = vacio;
            }
        }
        public void write(Bloque datos, int numero_de_bloque)
        {
            this._memoria[numero_de_bloque] = datos;
        }

        public Bloque read(int numero_de_bloque)
        {
            return this._memoria[numero_de_bloque];
        }

    }
}
