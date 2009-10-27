using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Procesador
{
    public class Nucleo
    {
        private Cache _cache;
        

        public Nucleo(ref Cache cache)
        {
            this._cache = cache;
        }

        public void procesar()
        {
            
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
