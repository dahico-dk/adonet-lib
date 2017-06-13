using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tb_baglantilog
    {

        private int _keyno;
        private string _id;
        private string _ip;
        private DateTime _start_time;
        private DateTime _end_time;
        private char _term;
        private string _versiyon;
       
       

        public int KEYNO { get { return _keyno; }set { _keyno = value; } }
        
        public string ID { get { return _id; }set { _id = value; } }
         public string IP { get { return _ip; }set { _ip = value; } }
        public DateTime START_TIME { get { return _start_time; }set { _start_time = value; } }
        public DateTime END_TIME { get { return _end_time; }set { _end_time = value; } }
         public char TERM { get { return _term; }set { _term = value; } }
        public string VERSIYON { get { return _versiyon; }set { _versiyon = value; } }
        public Tb_baglantilog() { }
        public Tb_baglantilog(int keyno, string id, string ip, DateTime start_time,DateTime end_time, char term, string versiyon)
        {
            this._keyno = keyno;
            this._id = id;
            this._ip = ip;
            this._start_time = start_time;
            this._end_time = end_time;
            this._term = term;
            this._versiyon = versiyon;
            
           
        }
    }
}
