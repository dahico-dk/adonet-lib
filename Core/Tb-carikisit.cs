using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tb_carikisit
    {
        private int _inckeyno;
        private string _carikod;
        private string _kisitalani;
        private string _kisitdegeri;
        private bool _durum;
        private string _sqltext;
        private string _aciklama;
       

        public int INCKEYNO { get { return _inckeyno; }set { _inckeyno = value; } }
        public string CARIKOD { get { return _carikod; } set { _carikod = value; } }
        public string KISITALANI { get { return _kisitalani; } set { _kisitalani = value; } }
        public string KISITDEGERI { get { return _kisitdegeri; } set { _kisitdegeri = value; } }
        public bool DURUM { get { return _durum; } set { _durum = value; } }
        public string SQLTEXT { get { return _sqltext; } set { _sqltext = value; } }
        public string ACIKLAMA { get { return _aciklama; } set { _aciklama = value; } }
        public Tb_carikisit() { }
        public Tb_carikisit(int inckeyno,string carikod,string kisitalani,string kisitdegeri,bool durum,string sqltext,string aciklama)
        {
            this._inckeyno = inckeyno;
            this._carikod = carikod;
            this._kisitalani = kisitalani;
            this._kisitdegeri = kisitdegeri;
            this._durum = durum;
            this._sqltext = sqltext;
            this._aciklama = aciklama;
            
           
        }

    }
}
