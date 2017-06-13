using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class KullaniciListele
    {
        private const string stored_proc_adi = "stored_proc_adi";//prosedur adı
              
        //tek nesne yükleme. List için while içinde ard arda çalışır.
        private static Core.TP_KULLANICI.User UserLoad(SqlDataReader read)
        {
            Core.TP_KULLANICI.User user = null; //DB'ye göre yaratılmış Core nesnesi
            try
            {
                user = new Core.TP_KULLANICI.User();
                user.kullaniciAdi = DbCommand.StringGetir(read, "kullaniciAdi");
                user.ePosta = DbCommand.StringGetir(read, "ePosta");
                user.aktifMi = DbCommand.BoolGetir(read, "aktifMi");              
            }
            catch (Exception ex)
            {
                //Hata durumunda log işlemleri.
            }
            return user;
        }  
        //dynamic yerine her seferinde uygun değer'de girilebilir. Kısa olması için dynamic kullandım.
        public static List<dynamic> ManuelSorguIslemı(string komut)
        {
            DbCommand command = new DbCommand();
            List<dynamic> userliste = new List<dynamic>();
            SqlDataReader read = null;           
            try
            {
                read = command.IsletManuelReader(komut);//Herhangi bir komut cümleciği. Komut işletiliyor.
                while (read.Read()) { userliste.Add(UserLoad(read)); } //read çalıştıkça nesneler listeye ekleniyor. 
            }
            catch (Exception ex)
            {
                //Hata bloğu. Log işlemleri
            }
            finally
            {
                //Memory allocation için command ve read nesnelerini yokediyoruz.
                read.Dispose();
                read.Close();
                command.Temizle();
            }
            return userliste;
        }
       
        //Store procedure'den liste dönme. Class'a gömülü
        public static List<Core.TP_KULLANICI.User> StoreProcedureSorgu()//proc için lazım olduğunda herhangi bir parametre alabilir (id vs.)
        {

            List<Core.TP_KULLANICI.User> userliste = new List<Core.TP_KULLANICI.User>();
            DbCommand command = new DbCommand(stored_proc_adi);
            command.AddParameter("@param1", "örnek parametre"); //Ornek olarak parametre ekleme
            command.AddParameter("@param1", "örnek parametre");
            command.AddParameterOut("@outputparam", System.Data.SqlDbType.NVarChar, 999); //Ornek output parametresi
            command.AddParameterOut("@outputparam2", System.Data.SqlDbType.NVarChar, 999);

            SqlDataReader read = null;
            try
            {
                read = command.IsletDataReader();
                while (read.Read()) { userliste.Add(UserLoad(read)); }              
            }
            catch (Exception ex) 
            {               
                //Hata bloğu
            }
            finally
            {
                //Memory allocation için command ve read nesnelerini yokediyoruz.
                read.Dispose();
                read.Close();
                //Output parametreleri read nesnesi kapandıktan sonra çekilmezse hata verir. 
                string output1 = command.OutParametreDegeriString("outputparam");
                string output2 = command.OutParametreDegeriString("outputparam2");
                command.Temizle();            
            }
            return userliste;
        }
        
        //Store procedure'den liste dönme. manuel
        public static List<Core.TP_KULLANICI.User> StoreProcedureSorguManuel(string spname)//proc için lazım olduğunda herhangi bir parametre alabilir (id vs.)
        {

            List<Core.TP_KULLANICI.User> userliste = new List<Core.TP_KULLANICI.User>();
            DbCommand command = new DbCommand(spname);
            command.AddParameter("@param1", "örnek parametre"); //Ornek olarak parametre ekleme
            command.AddParameter("@param1", "örnek parametre");
            command.AddParameterOut("@outputparam", System.Data.SqlDbType.NVarChar, 999); //Ornek output parametresi
            command.AddParameterOut("@outputparam2", System.Data.SqlDbType.NVarChar, 999);

            SqlDataReader read = null;
            try
            {
                read = command.IsletDataReader();
                while (read.Read()) { userliste.Add(UserLoad(read)); }
            }
            catch (Exception ex)
            {
                //Hata bloğu
            }
            finally
            {
                //Memory allocation için command ve read nesnelerini yokediyoruz.
                read.Dispose();
                read.Close();
                //Output parametreleri read nesnesi kapandıktan sonra çekilmezse boş gelir. 
                string output1 = command.OutParametreDegeriString("outputparam");
                string output2 = command.OutParametreDegeriString("outputparam2");
                command.Temizle();
            }
            return userliste;
        }

        //Update delete gibi sadece işlem gören ve dönüşü olmayan proclar icin
        public static bool TekIslemSP()
        {           
            DbCommand command = new DbCommand(stored_proc_adi);      
            SqlDataReader read = null; bool sonuc = false;
            try { sonuc = command.Islet() > 0 ? true : false; }
            catch (Exception ex)
            {

                //Hata bloğu
            }
            finally
            {
                //Memory allocation için command ve read nesnelerini yokediyoruz.
                read.Dispose();
                read.Close();
                command.Temizle();
            }
            return sonuc;
        }


        //Update delete gibi sadece işlem gören ve dönüşü olmayan komutlar icin
        public static bool TekIslemManuel(string komut)
        {
            DbCommand command = new DbCommand(stored_proc_adi);
            SqlDataReader read = null; bool sonuc = false;
            try { sonuc = command.IsletManuelNonReturn(komut) > 0 ? true : false; }
            catch (Exception ex)
            {

                //Hata bloğu
            }
            finally
            {
                //Memory allocation için command ve read nesnelerini yokediyoruz.
                read.Dispose();
                read.Close();
                command.Temizle();
            }
            return sonuc;
        }
       
    }
}
