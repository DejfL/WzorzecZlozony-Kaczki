using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecZlozony_Kaczki.Interface;

namespace WzorzecZlozony_Kaczki.Model
{
    public class Obserwowany : IKwakObserwowany
    {
        static ArrayList list = new ArrayList();
        IKwakObserwowany kaczka;
        
        public Obserwowany(IKwakObserwowany kaczka)
        {
            this.kaczka = kaczka;
        }

        public void PowiadomObserwatorow()
        {
            foreach (IObserwator item in list)
            {
                item.Aktualizuj(kaczka);
            }
        }

        public void ZarejestrujObserwatora(IObserwator obserwator)
        {
            list.Add(obserwator);
        }

    }
}
