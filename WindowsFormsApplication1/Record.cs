using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Record : Form
    {
        private string _gamemode;
        public Record(string gamemode)
        {
            InitializeComponent();
            _gamemode = gamemode;
        }

        private void Record_Load(object sender, EventArgs e)
        {
            List<RecordSave> rs = SaveFileManager.LoadAll(_gamemode);
            //List<RecordSomethingIGuess> iguess = RecordManager.LoadFile(_gamemode);
            foreach (RecordSave item in rs)
            {
                object[] obj = new object[3];
                obj[0] = item.Name;
                obj[1] = item.Turns;
                obj[2] = item.RecordTime.ToLongTimeString() + " - " + item.RecordTime.ToLongDateString();
              dataGridView1.Rows.Add(obj);
            }
        }
    }
}
