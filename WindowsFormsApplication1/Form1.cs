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
    public partial class Form1 : Form
    {
        List<GameModeClass> gameModeList = new List<GameModeClass>();
        public Dictionary<string,Label> LabelDic = new Dictionary<string, Label>();
       
        public Form1()
        {
            InitializeComponent();
            IEnumerable<GameModeClass> exporters = typeof(GameModeClass)
                                                    .Assembly.GetTypes()
                                                    .Where(t => t.IsSubclassOf(typeof(GameModeClass)) && !t.IsAbstract)
                                                    .Select(t => (GameModeClass)Activator.CreateInstance(t));
            gameModeList = exporters.ToList();


            LabelDic.Add("Player1XP", p1XP);
            LabelDic.Add("Player2XP", p2XP);
            LabelDic.Add("Player1HP", p1HP);
            LabelDic.Add("Player2HP", p2HP);
            LabelDic.Add("turnLabel", turnLabel);
            if (gameModeList.Count == 0)
                throw new Exception("No gamemode were found. Please make one or don't delete the standard modes");
            GameModeSelector.Text = gameModeList[0].Name;
            
            foreach (GameModeClass gmc in gameModeList)
            {
                GameModeSelector.Items.Add(gmc.Name);
                gmc.Initialize();
                gmc.labelDictionary = LabelDic;
                gmc.player1.XPLabel = p1XP;
                gmc.player1.HPLabel = p1HP;
                gmc.player2.XPLabel = p2XP;
                gmc.player2.HPLabel = p2HP;

            }

        }

        private void Player1_Click(object sender, EventArgs e)
        {
            gameModeList.Where(t => t.Name == GameModeSelector.Text).First().Turn();
        }

        private void SkipTurn_Click(object sender, EventArgs e)
        {
            gameModeList.Where(t => t.Name == GameModeSelector.Text).First().SkipTurn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Record rec = new Record(GameModeSelector.Text);
            rec.Show();
        }
    }
    
}
