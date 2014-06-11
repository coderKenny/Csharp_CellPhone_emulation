using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KannyKamera
{
    internal abstract class Puhelin
    {
        string vari;
        string valmistaja;

        internal abstract void soitaPuhelu(int puhelunPituuden);
    }
}
