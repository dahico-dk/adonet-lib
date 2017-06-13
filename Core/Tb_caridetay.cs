using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tb_caridetay
    {
        private string _cari_kod;
        private string _localip;
        private string _wanip;
        private string _bilgisayaradi;
        private string _username;
        private string _sistem;
        private string _hdd_fabrikakodu;
        private string _hdd_serialno;
        private DateTime _kayittarihi;
        private int _terminalno;
        private string _productid;
        private byte[] _resim;
        private int _inc;
        private string _cpuid;


        public string CARI_KOD { get { return _cari_kod; } set { _cari_kod = value; } }
        public string LOCALIP { get { return _localip; } set { _localip = value; } }
        public string WANIP { get { return _wanip; } set { _wanip = value; } }
        public string BILGISAYARADI { get { return _bilgisayaradi; } set { _bilgisayaradi = value; } }
        public string USERNAME { get { return _username; } set { _username = value; } }
        public string SISTEM { get { return _sistem; } set { _sistem = value; } }
        public string HDD_FABRIKAKODU { get { return _hdd_fabrikakodu; } set { _hdd_fabrikakodu = value; } }
        public string HDD_SERIALNO { get { return _hdd_serialno; } set { _hdd_serialno = value; } }
        public DateTime KAYITTARIHI { get { return _kayittarihi; } set { _kayittarihi = value; } }
        public int TERMINALNO { get { return _terminalno; } set { _terminalno = value; } }
        public string PRODUCTID { get { return _productid; } set { _productid = value; } }
        public byte[] RESIM { get { return _resim; } set { _resim = value; } }
        public int INC { get { return _inc; } set { _inc = value; } }
        public string CPUID { get { return _cpuid; } set { _cpuid = value; } }
         public Tb_caridetay() { }
         public Tb_caridetay(string cari_kod, string localip,string wanip, string bilgisayaradi, string username, string sistem, string hdd_fabrikakodu, string hdd_serialno, DateTime kayittarihi, int terminalno, string productid, byte[] resim, int inc, string cpuid)
        {
            this._cari_kod = cari_kod;
            this._localip = localip;
            this._wanip = wanip;
            this._bilgisayaradi = bilgisayaradi;
            this._username = username;
            this._sistem = sistem;
            this._hdd_fabrikakodu = hdd_fabrikakodu;
            this._hdd_serialno = hdd_serialno;
            this._kayittarihi = kayittarihi;
            this._terminalno = terminalno;
            this._productid = productid;
            this._resim = resim;
            this._inc = inc;
            this._cpuid = cpuid;
            
           
          
           
        }
    }
}
