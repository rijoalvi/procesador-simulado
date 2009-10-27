using System;
using System.Collections.Generic;
using System.Text;

namespace Procesador
{
    public class Bloque
    {
        private int[] _datos;
        public Bloque() 
        {
            this._datos = new int[4];
        }

        public void set_datos(int palabra, int dato) 
        {
            this._datos[palabra] = dato;
        }
        public int get_datos(int palabra)
        {
            return this._datos[palabra];
        }
    }
}
