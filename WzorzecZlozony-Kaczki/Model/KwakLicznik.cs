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
        IKwaczaca kaczka;
        static int liczbaKwakniec = 0;

        public KwakLicznik(IKwaczaca kaczka)
        {
            this.kaczka = kaczka;
        }

        public void Kwacz()
        {
            kaczka.Kwacz();
            liczbaKwakniec++;
        }

        public static int PobierzLiczbeKwakniec()
        {
            return liczbaKwakniec;
        }

        public void ZarejestrujObserwatora(IObserwator obserwator)
        {
            kaczka.ZarejestrujObserwatora(obserwator);
        }

        public void PowiadomObserwatorow()
        {
            kaczka.PowiadomObserwatorow();
        }

        public override String ToString()
        {
            return kaczka.ToString();
        }
    }
}
