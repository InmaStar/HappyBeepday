using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HappyBeepday
{
    class Currante
    {
        int frecuency;
        int duration;
        ConsoleColor color;
        static Random rnd = new Random();
        public static readonly ConsoleColor[] colors = { 
                    ConsoleColor.Blue,  ConsoleColor.Green,  ConsoleColor.Cyan,  ConsoleColor.Red, 
	                ConsoleColor.Magenta,  ConsoleColor.Yellow, ConsoleColor.White
                    };


        public Currante()
        {
            frecuency = rnd.Next(500, 1501);
            duration = rnd.Next(50, 301);
            color = colors[rnd.Next(colors.Length)];
        }

        public void Felicitar(){
             Thread.Sleep(rnd.Next(2000));
             Console.ForegroundColor = this.color;
             Console.WriteLine("¡Feliz cumpleaños!");
             Cancion.Beep(this.frecuency, this.duration);
        }
    }
}
