using System;
using System.Collections.Generic;
using System.Text;

namespace Procesador
{
    public class busDatos
    {
        memoriaPrincipal mem;
        public busDatos(memoriaPrincipal m) 
        {
            mem = m;
        }

        public void ponerEnMemoria(/*parametros de donde se quiere ubicadr la vara*/)
        {
            //Ojo que se dura 12 ciclos bajando y subiendo varas de memoria a cache
        }

        public int[] traerDeMemoria(/*parametros de donde esta ubicada la vara*/)
        {

            //Ojo que se dura 12 ciclos bajando y subiendo varas de memoria a cache

            int[] respuesta;
            respuesta = null;
            return respuesta;
        }
    }
}
