using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KannyKamera
{
    class Lankapuhelin:Puhelin
    {
        internal override void soitaPuhelu(int puhelunPituuden)
        {
            Console.WriteLine("\n\nSoitetaan lankapuhelimella " + puhelunPituuden + " minuutin pituinen puhelu laitteella " + this.GetType().Name);
            Apuluokka.InsertWideLineSepatator();
        }
    }
}
