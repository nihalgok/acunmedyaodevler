using ödev1.Kalıtım;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW();
            bmw.marka = "BMW";
            bmw.düz(bmw.marka);

            Porsche porsche = new Porsche();
            porsche.marka = "Porsche";
            porsche.otomatik(porsche.marka);

            Mercedes mercedes = new Mercedes();
            mercedes.marka = "Mercedes";
            mercedes.düz(mercedes.marka);

            Togg togg = new Togg();
            togg.marka = "Togg";
            togg.otomatik(togg.marka);

            Audi audi = new Audi();
            audi.marka = " Audi";
            audi.düz(audi.marka);

            Toyota toyota = new Toyota();
            toyota.marka = "Toyota";
            toyota.otomatik(toyota.marka);
        }

    }
}
