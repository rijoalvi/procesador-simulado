using System;
using System.Collections.Generic;
using System.Text;

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
        public void escribir_a_memoria_principal()
        {
            //Ojo que se dura 12 ciclos bajando y subiendo varas de memoria a cache
        }

        public int[] traer_de_memoria_principal(ref Cache cache, int numero_de_bloque_a_leer, int numero_de_bloque_de_escritura)
        {

            //Ojo que se dura 12 ciclos bajando y subiendo varas de memoria a cache
            //llama a otro metodo para relizar la escitura en cache en donde se bloquea con un mutex la cache temporalmente
            int[] respuesta;
            respuesta = null;
            return respuesta;
        }
    }
}
