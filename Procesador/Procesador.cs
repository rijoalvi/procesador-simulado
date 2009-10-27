using System;
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
        private static Memoria_Principal _memoria;
        private static Bus _bus;
        private Cache _cache;
        private Nucleo _nucleo;

        public Procesador()
        {
            
            _memoria = new Memoria_Principal();
            _bus = new Bus(ref _memoria);
            this._cache = new Cache(ref _bus);
            this._nucleo = new Nucleo(ref _cache);
            //Creaci�n de los hilos (N�cleos)
            Thread nucle_1 = new Thread(new ThreadStart(this._nucleo.procesar));
            Thread nucle_2 = new Thread(new ThreadStart(this._nucleo.procesar));
            Thread nucle_3 = new Thread(new ThreadStart(this._nucleo.procesar));
            Thread nucle_4 = new Thread(new ThreadStart(this._nucleo.procesar));

            //Colocaci�n de un ID a cada N�cleo (hilo)
            nucle_1.Name = "1";
            nucle_2.Name = "2";
            nucle_3.Name = "3";
            nucle_4.Name = "4";

            //Start y join de los hilos
            nucle_1.Start();
            nucle_2.Start();
            nucle_3.Start();
            nucle_4.Start();

            nucle_1.Join();
            nucle_2.Join();
            nucle_3.Join();
            nucle_4.Join();

            InitializeComponent();
        }
    }
}