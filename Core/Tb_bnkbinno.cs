using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tb_bnkbinno
    {
       private int _di;
       private string _binno;
       private string _bankakodu;
       private string _karttipi;
       private string _bankaadi;
        


        public int DI { get { return _di; }set { _di = value; } }
        public string BINNO { get { return _binno; }set { _binno = value; } }
       public string BANKAKODU { get { return _bankakodu; }set { _bankakodu = value; } }
         public string KARTTIPI { get { return _karttipi; }set { _karttipi = value; } }
         public string BANKAADI { get { return _bankaadi; }set { _bankaadi = value; } }
       
       
        public Tb_bnkbinno() { }
        public Tb_bnkbinno(int di, string binno, string bankakodu, string karttipi, string bankaadi)
        {
            this._di = di;
            this._binno = binno;
            this._bankakodu = bankakodu;
            this._karttipi = karttipi;
            this._bankaadi = bankaadi;
                                            
        }
    }
}
