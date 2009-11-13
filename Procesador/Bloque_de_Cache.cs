using System;
using System.Collections.Generic;
using System.Text;

namespace Procesador
{
    public class Bloque_de_Cache : Bloque
    {
        private bool _compartido;
        private bool _sucio;
        private bool _valido;
        private int _etiqueta;

        public Bloque_de_Cache() 
        :base()
        {
            this._compartido = false;
            this._sucio = false;
            this._valido = false;
            this._etiqueta =-1;
        }        
        public bool compartido
        {
            get { return this._compartido; }
            set { this._compartido = value; }
        }
        public bool sucio
        {
            get { return this._sucio; }
            set { this._sucio = value; }            
        }
        public bool valido
        {
            get { return this._valido; }
            set { this._valido = value; }
        }
        public int etiqueta
        {
            get { return this._etiqueta; }
            set { this._etiqueta = value; }
        }
    }
}
