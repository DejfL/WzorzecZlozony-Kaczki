using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecZlozony_Kaczki.Abstract;
using WzorzecZlozony_Kaczki.Interface;

namespace WzorzecZlozony_Kaczki.Model
{
    public class FabrykaKaczek : AbstrakcyjnaFabrykaKaczek
    {
        public override IKwaczaca UtworzDzikaKaczka()
        {
            return new DzikaKaczka();
        }

        public override IKwaczaca UtworzGumowaKaczka()
        {
            return new GumowaKaczka();
        }

        public override IKwaczaca UtworzPlaskonosKaczka()
        {
            return new PlaskonosKaczka();
        }

        public override IKwaczaca UtworzWabikKaczka()
        {
            return new WabikKaczka();
        }
    }
}
