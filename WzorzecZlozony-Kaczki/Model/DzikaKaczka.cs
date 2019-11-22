using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecZlozony_Kaczki.Interface;

namespace WzorzecZlozony_Kaczki.Model
{
    public class DzikaKaczka : IKwaczaca
    {
        Obserwowany obserwowany;

        public DzikaKaczka()
        {
            obserwowany = new Obserwowany(this);
        }
        public void Kwacz()
        {
            Console.WriteLine("Kwa kwa");
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

        public override String ToString()
        {
            return "Dzika kaczka";
        }
    }
}
