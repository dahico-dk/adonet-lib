using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public class Tb_bankahesapno
    {
         private string _bankaadi;
         private string _subesi;
         private string _hesap_no;
         private string _aciklama;
         private string _iban_no;
         private int _sira;
       

        public string BANKA_ADI { get { return _bankaadi; }set { _bankaadi = value; } }
        public string SUBESI { get { return _subesi; }set { _subesi = value; } }
        public string HESAP_NO { get { return _hesap_no; }set { _hesap_no = value; } }
        public string ACIKLAMA { get { return _aciklama; }set { _aciklama = value; } }
        public string IBAN_NO { get { return _iban_no; }set { _iban_no = value; } }
        public int SIRA { get { return _sira; }set { _sira = value; } }
        
        public Tb_bankahesapno() { }
        public Tb_bankahesapno(string banka_adi,string subesi,string hesap_no,string aciklama, string iban_no, int sira)
        {
            this._bankaadi = banka_adi;
            this._subesi = subesi;
            this._hesap_no = hesap_no;
            this._aciklama = aciklama;
            this._iban_no = iban_no;
            this._sira = sira;
            
           
        }
    }
}
