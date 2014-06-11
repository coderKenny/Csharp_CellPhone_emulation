using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KannyKamera
{
    class Matkapuhelin:Puhelin,Kamera
    {
        internal int akunkesto = 10;
        internal string name;

        public Matkapuhelin(int p,string name)
        {
            this.akunkesto = p;
            this.name = name;
        }


        public void otaKuva(int kuvienMaara)
        {
            if (akunkesto >= kuvienMaara)
            {
                Console.WriteLine("Otetaan "+kuvienMaara+" kuva(a) "+" laitteella "+ name);
                akunkesto -= kuvienMaara;
                Console.WriteLine("Akun varaus kuvauksen jälkeen : {0} ", akunkesto);
            }


            else
            {

                Console.WriteLine("Otetaan kuvia laitteella " + name);
                Console.WriteLine("Akku tyhjeni");
                Console.WriteLine("Kuvia saatiin otetuksi : " + akunkesto);

                akunkesto = 0;
            }

            
        }

        internal override void soitaPuhelu(int puhelunPituus)
        {
            if (akunkesto >= puhelunPituus)
            {
                Console.WriteLine("Soitetaan laitteella " + name);
                akunkesto -= puhelunPituus;
                Console.WriteLine("Akun varaus puhelun jälkeen : {0} ",akunkesto);
            }

            else
            {
                
                Console.WriteLine("Soitetaan laitteella " + name);
                Console.WriteLine("Akku tyhjeni");
                Console.WriteLine("Soiton pituus oli : "+akunkesto);

                akunkesto = 0;
            }
        }
    }
}
