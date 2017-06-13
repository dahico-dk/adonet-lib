using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tb_arama
    {
        private int _id;
        private DateTime _zamani;
        private string _kullid;
        private int _terminal_no;
        private string _kisit1;
        private string _kisit2;
        private string _kisit3;
        private string _kisit4;
        private string _kisit5;
        private string _kisit6;
        private string _kisit7;
        private string _kisit8;
        private string _kisit9;
        private string _kisit10;
        private string _kisit11;
        private string _kisit12;
        private string _kisit13;
        private string _kisit14;
        private int _sonuc;
        private float _aktifsure;
        
      
        public int ID { get { return _id; }set { _id = value; } }
        public DateTime ZAMANI { get { return _zamani; } set { _zamani = value; } }
        public string KULLID { get { return _kullid; }set { _kullid = value; } }
        public int TERMINAL_NO { get { return _terminal_no; }set { _terminal_no = value; } }
        public string KISIT1 { get { return _kisit1; } set { _kisit1 = value; } }
        public string KISIT2 { get { return _kisit2; } set { _kisit2 = value; } }
        public string KISIT3 { get { return _kisit3; } set { _kisit3 = value; } }
        public string KISIT4 { get { return _kisit4; } set { _kisit4 = value; } }
        public string KISIT5 { get { return _kisit5; } set { _kisit5 = value; } }
        public string KISIT6 { get { return _kisit6; } set { _kisit6 = value; } }
        public string KISIT7 { get { return _kisit7; } set { _kisit7 = value; } }
        public string KISIT8 { get { return _kisit8; } set { _kisit8 = value; } }
        public string KISIT9 { get { return _kisit9; } set { _kisit9 = value; } }
        public string KISIT10 { get { return _kisit10; } set { _kisit10 = value; } }
        public string KISIT11 { get { return _kisit11; } set { _kisit11 = value; } }
        public string KISIT12 { get { return _kisit12; } set { _kisit12 = value; } }
        public string KISIT13 { get { return _kisit13; } set { _kisit13 = value; } }
        public string KISIT14 { get { return _kisit14; } set { _kisit14 = value; } }
        public int SONUC { get { return _sonuc; } set { _sonuc = value; } }
        public float AKTIFSURE { get { return _aktifsure; } set { _aktifsure = value; } }
       
        
        public Tb_arama() { }
        public Tb_arama(int id, DateTime zamani, string kullid,int terminal_no,string kisit1,string kisit2,string kisit3,string kisit4,string kisit5,string kisit6,string kisit7,string kisit8,string kisit9,string kisit10,string kisit11,string kisit12,string kisit13,string kisit14,int sonuc, float aktifsure)
        {
            this._id = id;
            this._zamani = zamani;
            this._kullid = kullid;
            this._terminal_no = terminal_no;
            this._kisit1 = kisit1;
            this._kisit2 = kisit2;
            this._kisit3 = kisit3;
            this._kisit4 = kisit4;
            this._kisit5 = kisit5;
            this._kisit6 = kisit6;
            this._kisit7 = kisit7;
            this._kisit8 = kisit8;
            this._kisit9 = kisit9;
            this._kisit10 = kisit10;
            this._kisit11 = kisit11;
            this._kisit12 = kisit12;
            this._kisit13 = kisit13;
            this._kisit14 = kisit14;
            this._sonuc = sonuc;
            this._aktifsure = aktifsure;
           
           
        }

    }
}
