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
    public partial class Form1 : Form
    {
        public Form1()
        {
            Memoria_Principal memoria = new Memoria_Principal();
            Bus bus = new Bus(ref memoria);
            Procesador p = new Procesador(bus, memoria);

            //Creación de los hilos (Núcleos)
            Thread th1 = new Thread(new ThreadStart(p.procesar));
            Thread th2 = new Thread(new ThreadStart(p.procesar));
            Thread th3 = new Thread(new ThreadStart(p.procesar));
            Thread th4 = new Thread(new ThreadStart(p.procesar));

            //Colocación de un ID a cada Núcleo (hilo)
            th1.Name = "1";
            th2.Name = "2";
            th3.Name = "3";
            th4.Name = "4";

            //Start y join de los hilos
            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();

            th1.Join();
            th2.Join();
            th3.Join();
            th4.Join();

            InitializeComponent();
        }
    }
}