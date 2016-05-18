using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    static class SaveFileManager
    {
        public static void Save(string name, int turns, string FileName)
        {
            DateTime recordtime = DateTime.UtcNow;
            string savestring = name + "|" + turns.ToString() + "|" + recordtime.ToString();
            // DESCryptoServiceProvider descrypt = new DESCryptoServiceProvider();
            // descrypt.Key = Encoding.ASCII.GetBytes("HGTZQWEA");
            // descrypt.IV = Encoding.ASCII.GetBytes("HGTZQWEA");
            
            File.AppendAllText(FileName, "");
            List<RecordSave> rsl = LoadAll(FileName);

            using (Stream s = File.OpenWrite(FileName))
            {
                //   using (CryptoStream cs = new CryptoStream(s, descrypt.CreateEncryptor(), CryptoStreamMode.Write))
                //   {
                using (StreamWriter sw = new StreamWriter(s))
                {
                    foreach (var item in rsl)
                    {
                        sw.WriteLine(item.Name + "|" + item.Turns.ToString() + "|" + item.RecordTime.ToString());
                    }
                    sw.WriteLine(savestring);
                }
                //   }
            }
        }
        public static RecordSave Load(string FileName)
        {
            RecordSave rs = new RecordSave();
            using (Stream s = File.Open(FileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sw = new StreamReader(s))
                {
                    string str = sw.ReadLine();
                    string[] items = str.Split('|');
                    rs.Name = items[0];
                    rs.Turns = Convert.ToInt32(items[1]);
                    string[] secondsplit = items[2].Split(' ');
                    int[] datetime = secondsplit[0].Split('.').Select(x => int.Parse(x)).ToArray();
                    int[] daytime = secondsplit[1].Split(':').Select(x => int.Parse(x)).ToArray();
                    rs.RecordTime = new DateTime(datetime[2], datetime[1], datetime[0], daytime[0], daytime[1], daytime[2]);
                }
            }
            return rs;
        }
        public static List<RecordSave> LoadAll(string FileName)
        {
            var rsl = new List<RecordSave>();
            using (Stream s = File.Open(FileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                //DESCryptoServiceProvider descrypt = new DESCryptoServiceProvider();
                //descrypt.Key = Encoding.ASCII.GetBytes("HGTZQWEA");
                //descrypt.IV = Encoding.ASCII.GetBytes("HGTZQWEA");
                //using (CryptoStream cs = new CryptoStream(s, descrypt.CreateDecryptor(), CryptoStreamMode.Read))
                //{
                using (StreamReader sw = new StreamReader(s))
                {
                    string str = sw.ReadToEnd();
                    foreach (string item in str.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        RecordSave rs = new RecordSave();
                        string[] items = item.Split('|');
                        rs.Name = items[0];
                        rs.Turns = Convert.ToInt32(items[1]);
                        string[] secondsplit = items[2].Split(' ');
                        int[] datetime = secondsplit[0].Split('.').Select(x => int.Parse(x)).ToArray();
                        int[] daytime = secondsplit[1].Split(':').Select(x => int.Parse(x)).ToArray();
                        rs.RecordTime = new DateTime(datetime[2], datetime[1], datetime[0], daytime[0], daytime[1], daytime[2]);
                        rsl.Add(rs);
                    }
                }
                // }
            }
            return rsl;
        }
    }
    class RecordSave
    {
        public string Name { get; set; }
        public int Turns { get; set; }
        public DateTime RecordTime { get; set; }
        public RecordSave(string name, int turns, DateTime recordtime)
        {
            Name = name;
            Turns = turns;
            RecordTime = recordtime;
        }
        public RecordSave()
        {

        }
    }
}
