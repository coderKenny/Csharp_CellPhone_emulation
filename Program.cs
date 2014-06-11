using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KannyKamera
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Matkapuhelin nokia = new Matkapuhelin(10,"Nokia");
            Kamera kinoKamera = new Kinokamera();
            Puhelin lankaPuhelin = new Lankapuhelin();

            kinoKamera.otaKuva(4);
            lankaPuhelin.soitaPuhelu(30);

            List<Object> lista = new List<object>();
            lista.Add(nokia);
            lista.Add(kinoKamera);
            lista.Add(lankaPuhelin);



            foreach(object obj in lista)
            {
                Console.WriteLine("Objektin tiedot : " +obj.GetType().Name);
            }

            Apuluokka.WL();

            foreach (object obj in lista)
            {
                if(obj.GetType().Name.Equals("Matkapuhelin"))
                    Console.WriteLine("Objektin tiedot : " + obj.GetType().Name);

                else if(obj is Kamera)
                    Console.WriteLine("Objektin tiedot : " + obj.GetType().Name);
            }



            Apuluokka.InsertLineSepatator();



            while (nokia.akunkesto != 0)
            {
                int valinta;

                Console.WriteLine("Soitetaanko laitteella "+nokia.name+" syötä 1, muu luku otetaan kuvia");
                valinta = int.Parse(Console.ReadLine());

                if (valinta == 1)
                {
                    Console.WriteLine("Akun kesto : {0}", nokia.akunkesto);
                    Console.WriteLine("Soitetaan puhelu...");
                    int kesto;
                    Apuluokka.WL();
                    Console.WriteLine("Anna puhelun kesto");
                    kesto = int.Parse(Console.ReadLine());
                    nokia.soitaPuhelu(kesto);
                    Apuluokka.InsertWideLineSepatator();
                }

                else
                {
                    Console.WriteLine("Akun kesto : {0}", nokia.akunkesto);
                    Console.WriteLine("Otetaan kuvia...");
                    int kesto;
                    Apuluokka.WL();
                    Console.WriteLine("Anna kuvien määrä");
                    kesto = int.Parse(Console.ReadLine());
                    nokia.otaKuva(kesto);
                    Apuluokka.InsertWideLineSepatator();
                }
            }
      
            foreach(object obj in lista)
            {
                Console.WriteLine("Objektin tiedot : " +obj.GetType().Name);
            }

            Apuluokka.Pause();
        }
    }
}
