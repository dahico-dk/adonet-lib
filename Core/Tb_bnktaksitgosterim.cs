using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tb_bnktaksitgosterim
    {

        private int _inckeyno;
        private string _grupid;
        private int _gunbaslama;
        private int _htaksit;
        private int _gunbitis;

        public int INCKEYNO { get { return _inckeyno; } set { _inckeyno = value; } }
        public string GRUPID { get { return _grupid; } set { _grupid = value; } }

        public int GUNBASLAMA { get { return _gunbaslama; } set { _gunbaslama = value; } }
        public int HTAKSIT { get { return _htaksit; } set { _htaksit = value; } }
        public int GUNBITIS { get { return _gunbitis; } set { _gunbitis = value; } }

         public Tb_bnktaksitgosterim() { }
         public Tb_bnktaksitgosterim(int inckeyno, string grupid,int gunbaslama, int htaksit, int gunbitis)
        {
            this._inckeyno = inckeyno;
            this._grupid = grupid;
            this._gunbaslama = gunbaslama;
            this._htaksit = htaksit;
            this._gunbitis = gunbitis;
            
           
          
           
        }

    }
}
