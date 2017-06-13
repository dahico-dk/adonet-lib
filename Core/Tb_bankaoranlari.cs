using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tb_bankaoranlari
    {
        private int _idno;
        private string _bankaadi;
        private int _taksitsayisi;
        private decimal _oran;
        private char _fiyatpolitikasi;
        private int _ektaksitsayisi;
        private char _gosterim;
        private int _ertelemesayisi;
        private float _min_tutar;



        public int IDNO { get { return _idno; }set { _idno = value; } }
        public string BANKAADI { get { return _bankaadi; }set { _bankaadi = value; } }
        public int TAKSITSAYISI { get { return _taksitsayisi; }set { _taksitsayisi = value; } }
         public decimal ORAN { get { return _oran; }set { _oran = value; } }
        public char FIYATPOLITIKASI { get { return _fiyatpolitikasi; }set { _fiyatpolitikasi = value; } }
        public int EKTAKSITSAYISI { get { return _ektaksitsayisi; }set { _ektaksitsayisi = value; } }
        public char GOSTERIM { get { return _gosterim; }set { _gosterim = value; } }
         public int ERTELEMESAYISI { get { return _ertelemesayisi; }set { _ertelemesayisi = value; } }
        public float MIN_TUTAR { get { return _min_tutar; }set { _min_tutar = value; } }
        public Tb_bankaoranlari() { }
        public Tb_bankaoranlari(int idno, string bankaadi, int taksitsayisi,decimal oran, char fiyatpolitikasi, int ektaksitsayisi, char gosterim, int ertelemesayisi,float min_tutar)
        {
            this._idno = idno;
            this._bankaadi = bankaadi;
            this._taksitsayisi = taksitsayisi;
            this._oran = oran;
            this._fiyatpolitikasi = fiyatpolitikasi;
            this._ektaksitsayisi = ektaksitsayisi;
            this._gosterim = gosterim;
            this._ertelemesayisi = ertelemesayisi;
            this._min_tutar = min_tutar;
           
           
        }

    }
}
