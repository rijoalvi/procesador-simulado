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
            this.inicializar_datos();
        }
        public Bloque(Bloque b)
        {
            this._datos = new int[4];
            this._datos[0] = b.get_datos(0);
            this._datos[1] = b.get_datos(1);
            this._datos[2] = b.get_datos(2);
            this._datos[3] = b.get_datos(3);
        }
        private void inicializar_datos()
        {
            this._datos[0] = 0;
            this._datos[1] = 0;
            this._datos[2] = 0;
            this._datos[3] = 0;
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
