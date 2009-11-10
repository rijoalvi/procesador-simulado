using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Procesador
{
    public partial class Procesador : Form
    {
        private static Barrera _reloj_del_sistema;        
        private static Bus _bus;
        private static Memoria_Principal _memoria;
        private static Controlador_de_Caches _controlador_de_caches;
        private static Mutex _sincronizador_de_bus;
        private static Mutex _sincronizador_de_controlador_de_caches;
        
        private Nucleo _nucleo_1;
        private Nucleo _nucleo_2;
        private Nucleo _nucleo_3;
        private Nucleo _nucleo_4;
        

        public Procesador()
        {
            _reloj_del_sistema = new Barrera(4);
            _memoria = new Memoria_Principal();
            _bus = new Bus(ref _memoria);
            _controlador_de_caches = new Controlador_de_Caches();
            _sincronizador_de_bus = new Mutex();
            _sincronizador_de_controlador_de_caches = new Mutex();

            this._nucleo_1 = new Nucleo(ref _reloj_del_sistema, ref _bus, ref _controlador_de_caches, ref _sincronizador_de_bus, ref _sincronizador_de_controlador_de_caches);
            this._nucleo_2 = new Nucleo(ref _reloj_del_sistema, ref _bus, ref _controlador_de_caches, ref _sincronizador_de_bus, ref _sincronizador_de_controlador_de_caches);
            this._nucleo_3 = new Nucleo(ref _reloj_del_sistema, ref _bus, ref _controlador_de_caches, ref _sincronizador_de_bus, ref _sincronizador_de_controlador_de_caches);
            this._nucleo_4 = new Nucleo(ref _reloj_del_sistema, ref _bus, ref _controlador_de_caches, ref _sincronizador_de_bus, ref _sincronizador_de_controlador_de_caches);

            //Creación de los hilos (Núcleos)
            Thread nucleo_1 = new Thread(new ThreadStart(this._nucleo_1.procesar));
            Thread nucleo_2 = new Thread(new ThreadStart(this._nucleo_2.procesar));
            Thread nucleo_3 = new Thread(new ThreadStart(this._nucleo_3.procesar));
            Thread nucleo_4 = new Thread(new ThreadStart(this._nucleo_4.procesar));

            //Colocación de un ID a cada Núcleo (hilo)
            nucleo_1.Name = "1";
            nucleo_2.Name = "2";
            nucleo_3.Name = "3";
            nucleo_4.Name = "4";


            Cargador_de_Listas_de_Ejecucion prueba = new Cargador_de_Listas_de_Ejecucion();
            ArrayList listas = prueba.cargar_listas();
            this._nucleo_1.cargar_cache_de_instrucciones(((Lista_de_Instrucciones)listas[0]));
            this._nucleo_2.cargar_cache_de_instrucciones(((Lista_de_Instrucciones)listas[1]));
            this._nucleo_3.cargar_cache_de_instrucciones(((Lista_de_Instrucciones)listas[2]));
            this._nucleo_4.cargar_cache_de_instrucciones(((Lista_de_Instrucciones)listas[3]));
            //this._nucleo_1.cargar_cache_de_instrucciones(((Lista_de_Instrucciones)listas[4]));
            //this._nucleo_2.cargar_cache_de_instrucciones(((Lista_de_Instrucciones)listas[5]));
            //this._nucleo_3.cargar_cache_de_instrucciones(((Lista_de_Instrucciones)listas[6]));
            //this._nucleo_4.cargar_cache_de_instrucciones(((Lista_de_Instrucciones)listas[7]));
            //this._nucleo_1.cargar_cache_de_instrucciones(((Lista_de_Instrucciones)listas[8]));
            //this._nucleo_2.cargar_cache_de_instrucciones(((Lista_de_Instrucciones)listas[9]));
            //this._nucleo_1.procesar();


            //Start y join de los hilos
            nucleo_1.Start();
            nucleo_2.Start();
            nucleo_3.Start();
            nucleo_4.Start();

            nucleo_1.Join();
            nucleo_2.Join();
            nucleo_3.Join();
            nucleo_4.Join();
            
            InitializeComponent();
        }
    }
}