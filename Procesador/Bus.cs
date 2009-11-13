using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Procesador
{
    public class Bus
    {
        private Memoria_Principal _memoria;
        
        public Bus(ref Memoria_Principal memoria) 
        {
            this._memoria = memoria;            
        }
        public void escribir_a_memoria_principal(Bloque datos, int numero_de_bloque_a_escribir)
        {
            this._memoria.write(datos, numero_de_bloque_a_escribir/16);            
        }

        public Bloque traer_de_memoria_principal(int numero_de_bloque_a_leer)
        {                                    
            return this._memoria.read(numero_de_bloque_a_leer/16);            
        }
    }
}
