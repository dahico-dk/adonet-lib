using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tb_bankasabit
    {
        private string _bankaadi;
        private bool _tekcekim;
        private string _link;
        private int _pasif;
        private int _sirano;
        



        public string BANKAADI { get { return _bankaadi; }set { _bankaadi = value; } }
        public bool TEKCEKIM { get { return _tekcekim; } set { _tekcekim = value; } }
        public string LINK { get { return _link; } set { _link = value; } }
        public int PASIF { get { return _pasif; } set { _pasif = value; } }
        public int SIRANO { get { return _sirano; } set { _sirano = value; } }
       
       
        public Tb_bankasabit() { }
        public Tb_bankasabit(string bankaadi,bool tekcekim,string link, int pasif, int sirano)
        {
            this._bankaadi = bankaadi;
            this._tekcekim = tekcekim;
            this._link = link;
            this._pasif = pasif;
            this._sirano = sirano;
            
           
           
        }

    }
}
