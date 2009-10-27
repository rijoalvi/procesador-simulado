using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Procesador
{
    public class Procesador
    {
        Cache cache;
        Bus bus;
        Memoria_Principal mem;

        public Procesador(Bus b, Memoria_Principal m)
        {
            bus = b;
            mem = m;
        }

        public void procesar()
        {
            cache = new Cache(ref bus);
            for (int i = 0; i < 10; i++)
            {
                //Para obtener el id del hilo
                Console.WriteLine("Procesando Hilo " + System.Threading.Thread.CurrentThread.Name);
                if (4 == Int32.Parse(System.Threading.Thread.CurrentThread.Name))
                {
                    Console.WriteLine("\r\n");
                }

                Thread.Sleep(1000);
                //System.Windows.Forms.Application.Exit();
            }
            //System.Environment.Exit(1);
        }
    }
}
