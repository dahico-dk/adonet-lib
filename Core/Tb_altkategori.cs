using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public  class Tb_altkategori
   {

        private int _inckeyno;
        private string _kod;
        private string _aciklama;
       

        public int INCKEYNO { get { return _inckeyno; }set { _inckeyno = value; } }
        public string KOD { get { return _kod; }set { _kod = value; } }
        public string ACIKLAMA { get { return _aciklama; }set { _aciklama = value; } }
        
        public Tb_altkategori() { }
        public Tb_altkategori(int inckeyno, string aciklama, string kod)
        {
            this._inckeyno = inckeyno;
            this._aciklama = aciklama;
            this._kod = kod;
           
        }
   }
}
