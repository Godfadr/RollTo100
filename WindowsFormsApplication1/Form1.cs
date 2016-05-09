using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Player player1;
        Player player2;
        public Form1()
        {
            InitializeComponent();
            player1 = new Player("player1");
            player2 = new Player("player2");
        }
        bool turn = true;

        private void Player1_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                ConsoleApplication1.Program.Turn(player1, 1);
                turnLabel.Text = "Turn: " + player2.Name;
                p1HP.Text = player1.health_.ToString();
                p1XP.Text = player1.xp.ToString();
                finished(player1.health_, player1.xp, player1);
                turn = !turn;
                return;
            }
            ConsoleApplication1.Program.Turn(player2, 1);
            turnLabel.Text = "Turn: " + player1.Name;
            p2HP.Text = player2.health_.ToString();
            p2XP.Text = player2.xp.ToString();
            finished(player2.health_, player2.xp, player2);
            turn = !turn;
        }

        private void SkipTurn_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                ConsoleApplication1.Program.Turn(player1, 0);
                turnLabel.Text = "Turn: " + player2.Name;
                turn = !turn;
                return;
            }
            ConsoleApplication1.Program.Turn(player2, 0);
            turnLabel.Text = "Turn: " + player1.Name;
            turn = !turn;
        }

        private void finished(int hp, int xp, Player player)
        {
            if (hp >= 100 || xp >= 100)
            {
                MessageBox.Show("     " + player.Name + " has won!");
                this.Close();
            }
        }

        private void p1XP_Click(object sender, EventArgs e)
        {

        }

        private void p2XP_Click(object sender, EventArgs e)
        {

        }

        private void p2HP_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
