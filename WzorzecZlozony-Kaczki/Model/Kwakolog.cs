using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecZlozony_Kaczki.Interface;

namespace WzorzecZlozony_Kaczki.Model
{
    public class Kwakolog : IObserwator
    {
        public void Aktualizuj(IKwakObserwowany kwakObserwowany)
        {
            Console.WriteLine("Kwakolog: " + kwakObserwowany + " Kwaknela");
        }

    }
}
