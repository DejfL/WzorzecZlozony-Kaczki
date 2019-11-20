using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecZlozony_Kaczki.Interface;

namespace WzorzecZlozony_Kaczki.Model
{
    public class GumowaKaczka : IKwaczaca
    {
        Obserwowany obserwowany;

        public GumowaKaczka()
        {
            obserwowany = new Obserwowany(this);
        }

        public void Kwacz()
        {
            Console.WriteLine("Piszcze");
            PowiadomObserwatorow();
        }

        public void PowiadomObserwatorow()
        {
            obserwowany.PowiadomObserwatorow();
        }

        public void ZarejestrujObserwatora(IObserwator obserwator)
        {
            obserwowany.ZarejestrujObserwatora(obserwator);
        }
    }
}
