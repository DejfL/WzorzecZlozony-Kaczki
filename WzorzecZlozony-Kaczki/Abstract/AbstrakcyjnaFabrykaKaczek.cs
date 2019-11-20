using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecZlozony_Kaczki.Interface;

namespace WzorzecZlozony_Kaczki.Abstract
{
    public abstract class AbstrakcyjnaFabrykaKaczek
    {
        public abstract IKwaczaca UtworzDzikaKaczka();
        public abstract IKwaczaca UtworzPlaskonosKaczka();
        public abstract IKwaczaca UtworzWabikKaczka();
        public abstract IKwaczaca UtworzGumowaKaczka();
    }
}
