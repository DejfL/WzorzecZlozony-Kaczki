using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecZlozony_Kaczki.Abstract;
using WzorzecZlozony_Kaczki.Interface;
using WzorzecZlozony_Kaczki.Model;

namespace WzorzecZlozony_Kaczki
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstrakcyjnaFabrykaKaczek fabrykaKaczek = new FabrykaKaczekZLIcznikiem();
            AbstrakcyjnaFabrykaGesi fabrykaGesi = new FabrykaGesiZLicznkiem();
            Uruchom(fabrykaKaczek, fabrykaGesi);
        }

        static void Uruchom(AbstrakcyjnaFabrykaKaczek fabrykaKaczek, AbstrakcyjnaFabrykaGesi fabrykaGesi)
        {
            IKwaczaca dzikaKaczka = fabrykaKaczek.UtworzDzikaKaczka();
            IKwaczaca gumowaKaczka = fabrykaKaczek.UtworzGumowaKaczka();
            IKwaczaca plaskonosKaczka = fabrykaKaczek.UtworzPlaskonosKaczka();
            IKwaczaca wabikKaczka = fabrykaKaczek.UtworzWabikKaczka();
            IKwaczaca gesKaczka = fabrykaGesi.UtworzGes();

            Stado stado = new Stado();
            stado.Dodaj(dzikaKaczka);
            stado.Dodaj(gumowaKaczka);
            stado.Dodaj(plaskonosKaczka);
            stado.Dodaj(wabikKaczka);
            stado.Dodaj(gesKaczka);

            IKwaczaca dzikaKaczka1 = fabrykaKaczek.UtworzDzikaKaczka();
            IKwaczaca dzikaKaczka2 = fabrykaKaczek.UtworzDzikaKaczka();
            IKwaczaca dzikaKaczka3 = fabrykaKaczek.UtworzDzikaKaczka();
            IKwaczaca dzikaKaczka4 = fabrykaKaczek.UtworzDzikaKaczka();

            Stado stadoDzikichKaczek = new Stado();
            stadoDzikichKaczek.Dodaj(dzikaKaczka1);
            stadoDzikichKaczek.Dodaj(dzikaKaczka2);
            stadoDzikichKaczek.Dodaj(dzikaKaczka3);
            stadoDzikichKaczek.Dodaj(dzikaKaczka4);

           // stado.Dodaj(stadoDzikichKaczek);

            Console.WriteLine("Symulator kaczek stado");

            Kwakolog kwakolog = new Kwakolog();
            stado.ZarejestrujObserwatora(kwakolog);
            
            Uruchom(stado);

            //Console.WriteLine("Symulator dzikich kaczek");
            //Uruchom(stadoDzikichKaczek);

            Console.WriteLine("Kaczki kwakaly: " + KwakLicznik.PobierzLiczbeKwakniec());

            Console.ReadKey();
        }

        static void Uruchom(IKwaczaca kwaczaca)
        {
            kwaczaca.Kwacz();
        }
    }
}
