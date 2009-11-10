using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Procesador
{
    public class Nucleo
    {        
        private const int  _QUANTUM_  = 30;
        private Barrera _reloj_del_sistema;
        private Bus _bus;
        private Controlador_de_Caches _controlador_de_caches;
        private Cache_de_Datos _cache_de_datos;
        private Cache_de_Instrucciones _cache_de_instrucciones;        

        public Nucleo(ref Barrera reloj_del_sistema, ref Bus bus, ref Controlador_de_Caches controlador_de_caches, ref Mutex sincronizador_de_bus, ref Mutex sincronizador_de_controlador_de_caches)
        {
            
            Mutex mutex_cache = new Mutex();                        
            this._reloj_del_sistema = reloj_del_sistema;
            this._bus = bus;
            this._controlador_de_caches = controlador_de_caches;
            this._cache_de_datos = new Cache_de_Datos(ref _bus, 0, ref sincronizador_de_bus, ref mutex_cache, ref _reloj_del_sistema);            
            this._controlador_de_caches.agregar_cache(ref this._cache_de_datos);
            this._controlador_de_caches.agregar_mutex(ref mutex_cache);
            this._cache_de_instrucciones = new Cache_de_Instrucciones(ref this._cache_de_datos, ref this._reloj_del_sistema, ref this._controlador_de_caches, ref sincronizador_de_controlador_de_caches, ref mutex_cache);
        }
        public void procesar()
        {
            while(this._cache_de_instrucciones.nuemro_de_listas_por_ejecutar !=0)
            {
                this._cache_de_instrucciones.ejecutar_instruccion();
            }
            
        }
        public void cargar_cache_de_instrucciones(Lista_de_Instrucciones listas_de_instrucciones)
        {
            this._cache_de_instrucciones.cargar_listas_de_ejecucion(listas_de_instrucciones);
        }
    }
}