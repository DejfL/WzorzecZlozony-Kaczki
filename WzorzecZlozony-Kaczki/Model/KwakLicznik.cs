using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecZlozony_Kaczki.Interface;

namespace WzorzecZlozony_Kaczki.Model
{
    public class KwakLicznik : IKwaczaca
    {
        Obserwowany obserwowany;
        IKwaczaca kaczka;
        static int liczbaKwakniec = 0;

        public KwakLicznik(IKwaczaca kaczka)
        {
            this.kaczka = kaczka;
            //obserwowany = new Obserwowany(this);
        }

        public void Kwacz()
        {
            kaczka.Kwacz();
            liczbaKwakniec++;
            PowiadomObserwatorow();
        }

        public static int PobierzLiczbeKwakniec()
        {
            return liczbaKwakniec;
        }

        public void ZarejestrujObserwatora(IObserwator obserwator)
        {
           // obserwowany.ZarejestrujObserwatora(obserwator);
        }

        public void PowiadomObserwatorow()
        {
          //  obserwowany.PowiadomObserwatorow();
        }
    }
}
