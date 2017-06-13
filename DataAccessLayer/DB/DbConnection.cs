using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class DbConnection
    {
        //mvc de sql baglanstısında zaman aşımı hatası alırsan başlat>çalıştır>cliconfg.exe dosyasını çalıştır ....etkinleştirilen iletişim kuralları TCP/IP üste olucak şekilde alttaki iki seçenekte işaret konulmadan 
        // sql connection cümlesi db yeri ip değiştiğinde sadece burda değişiklik yapmak yeterli olacaktır...
        public static readonly string connectionString = DB.Helper.connectionstring();
        /// <summary>
        /// bir bağlantı metni olusturularak yollanılıyor....
        /// </summary>
        /// <returns></returns>
        public static SqlConnection ConnectionGet()
        {
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
        /// <summary>
        /// sql connection baglantısının kapatılması.....
        /// </summary>
        /// <param name="connection"></param>
        public static void ConnectionClose(SqlConnection connection)
        {
            if (connection == null)
            {
                return;
            }
            connection.Close();
            connection.Dispose();
        }
    }
}
