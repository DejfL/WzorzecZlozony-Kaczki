using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecZlozony_Kaczki.Interface;

namespace WzorzecZlozony_Kaczki.Model
{
    public class Stado : IKwaczaca
    {
        ArrayList list = new ArrayList();

        public void Dodaj(IKwaczaca kwaczaca)
        {
            list.Add(kwaczaca);
        }
        public void Kwacz()
        {
            foreach (IKwaczaca item in list)
            {
                PowiadomObserwatorow();
                item.Kwacz();
            }
        }

        public void PowiadomObserwatorow()
        {
            foreach (IKwaczaca item in list)
            {
                Obserwowany obserwowany = new Obserwowany(item);
                obserwowany.PowiadomObserwatorow();
            }
        }

        public void ZarejestrujObserwatora(IObserwator obserwator)
        {
            foreach (IKwaczaca item in list)
            {
                Obserwowany obserwowany = new Obserwowany(item);
                obserwowany.ZarejestrujObserwatora(obserwator);
            }
        }
    }
}
