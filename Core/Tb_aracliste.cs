using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tb_aracliste
    {

        private int _inckeyno;
        private string _marka;
        private string _model;
       

        public int INCKEYNO { get { return _inckeyno; }set { _inckeyno = value; } }
        public string MARKA { get { return _marka; } set { _marka = value; } }
        public string MODEL { get { return _model; }set { _model = value; } }
        
        public Tb_aracliste() { }
        public Tb_aracliste(int inckeyno, string aciklama, string kod)
        {
            this._inckeyno = inckeyno;
            this._marka = aciklama;
            this._model = kod;
           
        }
    }
}
