using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;

namespace hardware_store
{
    public static class DBclass
    {
        public static void Connect()
        {
            try
            {
                GetConnection().Open();
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к бд", "Ошибка");
            }
        }
        public static SQLiteConnection GetConnection()
        {
                string pathsqlDB = "data source=info.db";
                SQLiteConnection connection = new SQLiteConnection(pathsqlDB);
                return connection;        
        }

        public static Image ByteToImage(byte[] imageBytes)
        {
            try
            {
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = new Bitmap(ms);
                return image;
            }
            catch
            {
                MessageBox.Show("ошибка при загрузке изображения из бд", "ошибка");
                return null;
            }
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }


    }
}
