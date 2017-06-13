using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class TestFacade:IDisposable // Memory aloc icin facade using içinde kullanılacak
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<dynamic> TestPull()
        {
            List<dynamic> duylist = new List<dynamic>();
            List<Core.TP_KULLANICI.User> OSList = new List<Core.TP_KULLANICI.User>();
            List<Core.TP_KULLANICI.User> OSList2 = new List<Core.TP_KULLANICI.User>();
            List<Core.TP_KULLANICI.User> OSList3 = new List<Core.TP_KULLANICI.User>();
            try {
                duylist = DataAccessLayer.KullaniciListele.ManuelSorguIslemı("Select * from Test2");//Manuel Komut
                OSList = DataAccessLayer.KullaniciListele.StoreProcedureSorgu();//Gomulu sp
                OSList2 = DataAccessLayer.KullaniciListele.StoreProcedureSorguManuel("testsp");//Manuel sp
                bool oldumu = DataAccessLayer.KullaniciListele.TekIslemManuel("DELETE FROM Customers");//tek ıslem manuel
                bool oldumu2 = DataAccessLayer.KullaniciListele.TekIslemSP();//Gomulu sp
                //Tek Islem metodları true false doner. Başarılı ise true aksi takdirde false.
            }
            
            catch (Exception x)
            {

                //Helper.Utilities.LogError(x); throw;
            }

            return duylist;
        }

    }
}
