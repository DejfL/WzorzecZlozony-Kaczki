using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecZlozony_Kaczki.Interface;

namespace WzorzecZlozony_Kaczki.Model
{
    public class GesAdapter : IKwaczaca
    {
        Obserwowany obserwowany;
        Ges ges;

        public GesAdapter(Ges ges)
        {
            this.ges = ges;
            obserwowany = new Obserwowany(this);
        }

        public void Kwacz()
        {
            ges.Gegaj();
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
