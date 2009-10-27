using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Procesador
{
    public class Bus
    {
        private Memoria_Principal _memoria;
        private bool _ocupado;
        public Bus(ref Memoria_Principal memoria) 
        {
            this._memoria = memoria;
            this._ocupado = false;
        }

        public bool ocupado
        {
            set{this._ocupado = value;}
            get { return this._ocupado; }
            
        }
        public void escribir_a_memoria_principal(Bloque datos, int numero_de_bloque_a_escribir)
        {
            this._memoria.write(datos, numero_de_bloque_a_escribir);
        }

        public void traer_de_memoria_principal(ref Cache cache, int numero_de_bloque_a_leer, int numero_de_bloque_de_escritura)
        {
            Bloque temporal = new Bloque();
            this._memoria.read(ref temporal, numero_de_bloque_a_leer);
            
        }
        private void escritura_con_bloqueo_a_cache(ref Cache cache, Bloque datos ,int numero_de_bloque_de_escritura)
        {

        }
    }
}
