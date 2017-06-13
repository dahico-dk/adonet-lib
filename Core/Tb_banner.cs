using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tb_banner
    {
        private int _inckeyno;
        private DateTime _baslama_zamani;
        private DateTime _bitis_zamani;
        private  byte[] _resim;
        private string _aciklama;
        private string _aramatext;
        private string _marka;
        private string _link;
        private char _islink;



        public int INCKEYNO { get { return _inckeyno; }set { _inckeyno = value; } }
         public DateTime BASLAMA_ZAMANI { get { return _baslama_zamani; }set { _baslama_zamani = value; } }
         public DateTime BITIS_ZAMANI { get { return _bitis_zamani; }set { _bitis_zamani = value; } }
         public byte[] RESIM { get { return _resim; }set { _resim = value; } }
         public string ACIKLAMA { get { return _aciklama; }set { _aciklama = value; } }
         public string ARAMATEXT { get { return _aramatext; }set { _aramatext = value; } }
        public string MARKA { get { return _marka; }set { _marka = value; } }
         //public string LINK { get { return _link; }set { _link = value; } }
         //public char LINK { get { return _islink; }set { _islink = value; } }

       
       
       
        public Tb_banner() { }
        public Tb_banner(int inckeyno, DateTime baslama_zamani, DateTime bitis_zamani, byte[] resim, string aciklama, string aramatext, string marka, string link, char islink)
        {
            this._inckeyno = inckeyno;
            this._baslama_zamani = baslama_zamani;
            this._bitis_zamani = bitis_zamani;
            this._resim = resim;
            this._aciklama = aciklama;
            this._aramatext = aramatext;
            this._marka = marka;
            this._link = link;
            this._islink = islink;
           
            
           
           
        }
    }
}
