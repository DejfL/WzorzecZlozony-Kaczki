using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecZlozony_Kaczki.Abstract;
using WzorzecZlozony_Kaczki.Interface;

namespace WzorzecZlozony_Kaczki.Model
{
    public class FabrykaGesiZLicznkiem : AbstrakcyjnaFabrykaGesi
    {
        public override IKwaczaca UtworzGes()
        {
            return new KwakLicznik(new GesAdapter(new Ges()));
        }
    }
}
