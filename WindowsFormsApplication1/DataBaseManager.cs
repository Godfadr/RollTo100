using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace WindowsFormsApplication1
{
    static class DataBaseManager
    {
        public static List<RecordSomethingIGuess> LoadFile(string DataBaseName)
        {
            LiteDatabase db = new LiteDatabase(DataBaseName + ".db");
            LiteCollection<RecordSomethingIGuess> records
                = db.GetCollection<RecordSomethingIGuess>("records");
            return records.FindAll().ToList();
        }

        public static void SaveFile(List<RecordSomethingIGuess> list, string DataBaseName)
        {
            LiteDatabase db = new LiteDatabase(DataBaseName + ".db");
            LiteCollection<RecordSomethingIGuess> records
                = db.GetCollection<RecordSomethingIGuess>("records");
            records.InsertBulk(list);
        }
        public static void SaveFile(RecordSomethingIGuess RecordItem, string DataBaseName)
        {
            LiteDatabase db = new LiteDatabase(DataBaseName + ".db");
            LiteCollection<RecordSomethingIGuess> records
                = db.GetCollection<RecordSomethingIGuess>("records");
            records.Insert(RecordItem);
        }
    }
    public class RecordSomethingIGuess
    {
        public string Name { get; set; }
        public int Turns { get; set; }
        public DateTime RecordTime { get; set; }

        public RecordSomethingIGuess() { }

        public RecordSomethingIGuess(string name, int turns)
        {
            Name = name;
            Turns = turns;
            RecordTime = DateTime.UtcNow;
        }
    }
}
