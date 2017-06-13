using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.TP_KULLANICI
{
    public class User
    {
        //DB'den gelecek verilerin izdüşümü olarak her bir kolon için ayrı prop yaratılıyor. 

        // public int MyProperty { get; set; } şeklinde auto set get veya eski usül get set ile yazılabilir.


        public string kullaniciAdi { get; set; }
        public string ePosta { get; set; }

        public bool aktifMi { get; set; }
    }
}
