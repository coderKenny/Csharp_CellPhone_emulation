using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KannyKamera
{
    class Kinokamera:Kamera
    {
        internal int otettujenKuvienMaara = 0;

        public void otaKuva(int kuvienMaara)
        {
            Console.WriteLine("\n\nOtetaan " + kuvienMaara + " kuva(a), laitteella "+this.GetType().Name);
        }
    }
}
