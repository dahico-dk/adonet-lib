# adonet-lib

ADO.NET-LIB farklı sınıf kütüphanelerine bölünmüş bir ADO.NET projesidir. Projesinde ADO.NET kullanmak isteyenler bu projenin mantığını referans alarak kendi projelerine entegre edebilirler.

SAMPLE projesi bu bağlantı tipini uygulayan bir MVC projesidir.

ADO.NET ile ilişkili dosyalar DataAccessLayer,Facade ve Core sınıf kütüphanelerinde yer alır.Kullanıcı talep doğrultusunda bu sınıf kütüphanelerini tek bir sınıf kütüphanesi altında birleştirerek klasörlerle birbirinden ayırma yoluna gidebilir.

### Veritabanı bağlantısı:

  *Proje veritabanı bağlantılarını entegre edildiği .NET Projesinin config dosyasından çeker. Kullanıcı config dosyasını kullanmak istemez ise bağlantı cümleciği ayarları DataAccessLayer/DB/DbConnection sınıfındadır. 

  *DataAccessLayer sınıf kütüphanesindeki Helper sınıfı config dosyasından bağlantı cümleciği olusturma işlemini yapar.

  *DBConnection sınıfı veritabanı bağlantısını açar.

  ```
  public static readonly string connectionString = DB.Helper.connectionstring();
  ```
  ---

  Proje genel olarak 3 sınıf kütüphanesinden meydana gelmektedir.
  
  #Core
  
  Core kütüphanesi veritabanı nesneleri ile eşlenecek sınıfları barındırır. Veritabanından dönen veriler bu sınıflara yüklenir. ç içe sınıflar ya da yapıcı metodlar yardımı ile farklı şekillerde bu nesneler tek dosyada yaratılabilir. Ben ayrı sınıflarda tutmayı tercih ediyorum.
  ```
   public class User
    {       
        public string kullaniciAdi { get; set; }
        public string ePosta { get; set; }
        public bool aktifMi { get; set; }
    }
  
  ```
  #DataAccessLayer
  
  Bütün veritabanı işlemlerinin yapıldığı katman bu katmandır. 
  
  KullaniciListele.cs sınıfı örnek olarak yaratılmış bir classtır. Bu kütüphane DBConnection ve DBCommand sınıflarını kullanarak veritabanı ile bütün etkileşimi sağlayan sınıftır.
  
  ```
  private static Core.TP_KULLANICI.User UserLoad(SqlDataReader read)
        {
            Core.TP_KULLANICI.User user = null; 
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
  ```
  UserLoad nesnesi örnek bir load nesnesidir. Bütün temel sorgu işlemlerinde geriye dönen değerler while döngüsü içinde UserLoad (-ya da tekrar yazılacak başka nesneler için başka load metodları veya global bir load metodu) ile çekilir. Buradaki stored_proc_adi class'a gömülü olan property'dir. Elle girmek için StoreProcedureSorguManuel("SP_ADI") metodu kullanılır.
    
  ```
  
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
                while (read.Read()) {  userliste.Add(UserLoad(read)); }              
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
  
  ```
  
  Burada UserLoad ile birlikte örnek olarak StoreProcedureSorgu metodu kullanılmıştır. Önce yükleme yapılacak olan liste yaratılıp ardından yeni bir DBCommand nesnesi yaratılmıştır. DbCommand nesnesi yaratılış esnasında bir stored procedure ismi ile ya da boş olarak yaratılabilir. AddParameter ve AddParameterOut komutları kullanılarak sp için gerekli parametreler(eğer var ise) yaratılır. Ardından DBCommandın IsletDataReader() metodu ile SQLDataReader nesnesine yükleme yapılır. 
  
  While içinde  userliste.Add(UserLoad(read)); komutu ile her okuma esnasında elde edilen Db'den dönen veriler User nesnesinin gerekli özelliklerine eşlendikten sonra listeye eklenir.
  
  finally kısmında ise read ve command nesneleri kapatılarak gereksiz hafıza kaplamalarının önüne geçilir.
  
  Output parametreleri kullanılıyor ise bunların değerleri read nesnesi kapatıldıktan sonra alınmalıdır. Aksi takdirde boş gelecektir.
  
  ### Geriye değer dönmeyen işlemler
  
  Update delete gibi geriye bir değer dönmeyen işlemler için TekIslemSP() ve TekIslemManuel() metodları kullanılır. Bu metodlar geriye int tipinden veri dönerler. Negatif dönüş işlemin hata verdiğini belirtir. Pozitif değer ise başarılı olduğunu. Metod geriye true false dönerek bir üst katmana işlemin başarılı mı başarısız mı olduğunu belirtir.
  
  ```
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

```
 #Facade
 
 Bu katman proje ile direk temas eden katmandır. Bu metodda birden fazla DataAccessLayer metodunun kullanılışı gösterilmiştir.
 
 ``` 
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
 
 ```

# Proje

Projede sadece Facade sınıfı kullanılır. using içinde kullanılarak hafıza yönetimi  sağlanır.

```
        List<dynamic> test = null;
            using (Facade.TestFacade tf=new Facade.TestFacade()) //Kullan at
            {
               test= tf.TestPull();
               
            }
```
