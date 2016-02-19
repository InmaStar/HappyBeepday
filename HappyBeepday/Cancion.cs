using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace HappyBeepday
{
    static class Cancion
    {
        public enum Notas
        {
            DO = 261, RE = 293, MI = 329,
            FA = 349, SOL = 392, LA = 440, SI = 493,
        };

        public static readonly int compas = 1250;
        public static readonly double negra = 1 / 4;
        public static readonly double blanca = 1 / 2;
        public static readonly double corchea = 1 / 8;

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);

        //este codigo haría llorar a Ortín
        public static void Musicote()
        {
            Beep((int)Notas.SOL, (int)((int)(compas * corchea)));
            Beep((int)Notas.SOL, (int)(compas * corchea));
            Beep((int)Notas.LA, (int)(compas * negra));
            Beep((int)Notas.SOL, (int)(compas * negra));
            Beep((int)Notas.DO, (int)(compas * negra));
            Beep((int)Notas.SI, (int)(compas * blanca));
            Beep((int)Notas.SOL, (int)(compas * negra));
            Beep((int)Notas.DO, (int)(compas * negra));
            Beep((int)Notas.SOL, (int)(compas * corchea));
            Beep((int)Notas.SOL, (int)(compas * corchea));
            Beep((int)Notas.LA, (int)(compas * negra));
            Beep((int)Notas.SOL, (int)(compas * negra));
            Beep((int)Notas.RE, (int)(compas * negra));
            Beep((int)Notas.DO, (int)(compas * blanca));
            Beep((int)Notas.DO, (int)(compas * corchea));
            Beep((int)Notas.MI, (int)(compas * corchea));
            Beep((int)Notas.SOL, (int)(compas * negra));
            Beep((int)Notas.MI, (int)(compas * negra));
            Beep((int)Notas.DO, (int)(compas * negra));
            Beep((int)Notas.SI, (int)(compas * negra));
            Beep((int)Notas.LA, (int)(compas * negra));
            Beep((int)Notas.FA, (int)(compas * corchea));
            Beep((int)Notas.FA, (int)(compas * corchea));
            Beep((int)Notas.MI, (int)(compas * negra));
            Beep((int)Notas.DO, (int)(compas * negra));
            Beep((int)Notas.RE, (int)(compas * negra));
            Beep((int)Notas.DO, (int)(compas * blanca));
            Beep((int)Notas.SOL, (int)(compas * corchea));
            Beep((int)Notas.SOL, (int)(compas * corchea));
            Beep((int)Notas.LA, (int)(compas * negra));
            Beep((int)Notas.SOL, (int)(compas * negra));
            Beep((int)Notas.DO, (int)(compas * negra));
            Beep((int)Notas.SI, (int)(compas * blanca));
            Beep((int)Notas.SOL, (int)(compas * corchea));
            Beep((int)Notas.SOL, (int)(compas * corchea));
            Beep((int)Notas.LA, (int)(compas * negra));
            Beep((int)Notas.SOL, (int)(compas * negra));
            Beep((int)Notas.RE, (int)(compas * negra));
            Beep((int)Notas.DO, (int)(compas * blanca));
            Beep((int)Notas.DO, (int)(compas * corchea));
            Beep((int)Notas.MI, (int)(compas * corchea));
            Beep((int)Notas.SOL, (int)(compas * negra));
            Beep((int)Notas.MI, (int)(compas * negra));
            Beep((int)Notas.DO, (int)(compas * negra));
            Beep((int)Notas.SI, (int)(compas * negra));
            Beep((int)Notas.LA, (int)(compas * negra));
            Beep((int)Notas.FA, (int)(compas * corchea));
            Beep((int)Notas.FA, (int)(compas * corchea));
            Beep((int)Notas.MI, (int)(compas * negra));
            Beep((int)Notas.DO, (int)(compas * negra));
            Beep((int)Notas.RE, (int)(compas * negra));
            Beep((int)Notas.DO, (int)(compas * blanca));
        }
    }
}
