using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace HappyBeepday
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("¡FELICIDADES!");
            Console.WriteLine("¿Cuántos cumples?");
            string resp = Console.ReadLine();
            uint tacos = Convert.ToUInt32(resp);

            //MUERTE POR CONTEXT SWITCHING
            //Thread[] threads = new Thread[tacos];
            //for (int i = 0; i < tacos; i++)
            //    threads[i] = new Thread(new Currante().Felicitar);
            //foreach (Thread thread in threads)
            //    thread.Start();
            //foreach (Thread thread in threads)
            //    thread.Join();

            //VERSION DECENTE
            Currante[] currantes = new Currante[tacos];
            for (int i = 0; i < tacos; i++)
                currantes[i] = new Currante();
            Parallel.ForEach(currantes, currante => currante.Felicitar());

            Thread.Sleep(4000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Ahora la versión seria.");
            Thread.Sleep(1000);
            new Thread(Cancion.Musicote).Start();
            Console.WriteLine("¡FELICIDADES!");
    }
        catch (Exception e)
        {
            Console.WriteLine("¡Buen intento pero no!");
            Thread.Sleep(3000);
        }
            
        }
    }
}
