using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecZlozony_Kaczki.Interface
{
    public interface IKwakObserwowany
    {
        void ZarejestrujObserwatora(IObserwator obserwator);
        void PowiadomObserwatorow();
    }
}
