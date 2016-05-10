using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class GamemodeWithObstacles : GameModeClass
    {

        bool turn = true;
        public override Dictionary<string, Label> labelDictionary
        {
            get;
            set;
        }

        public override Player player1
        {
            get;
            set;
        }

        public override Player player2
        {
            get;
            set;
        }

        public override void Initialize()
        {
            player1 = new Player("Hamlet", 50);
            player2 = new Player("MaxyBoy", 50);
        }

        public override void SkipTurn()
        {
            turn = !turn;
        }

        Obstacles ob = new Obstacles();
        Dice d = new Dice(20);
        public override void Turn()
        {
            int DiceNumber = d.DiceNumber;
            if (turn == true)
            {
                DamageThePlayer(player1, DiceNumber);
                HealThePlayer(player1, DiceNumber);
                player1._turns++;
                labelDictionary["turnLabel"].Text = "Turn: " + player2.Name;
                finished(player1);
            }
            else
            {
                DamageThePlayer(player2, DiceNumber);
                HealThePlayer(player2, DiceNumber);
                player2._turns++;
                labelDictionary["turnLabel"].Text = "Turn: " + player1.Name;
                finished(player2);
            }
            turn = !turn;
        }
        private void finished(Player player)
        {
            player.HPLabel.Text = player._health.ToString();
            player.XPLabel.Text = player._xp.ToString();

            if (player._health == 100)
            {
                MessageBox.Show("Player " + player.Name + " has won!");
            }
        }
        private void DamageThePlayer(Player player, int DiceNumber)
        {
            if (DiceNumber < 3)
            {
                player._health -= ob.boulder1;
                player._xp = -15;
            }
            else if (DiceNumber < 5)
            {
                player._health -= ob.boulder2;
                player._xp = -10;
            }
            else if (DiceNumber < 7)
            {
                player._health -= ob.boulder3;
                player._xp = -7;
            }
            else if (DiceNumber < 9)
            {
                player._health -= ob.boulder4;
                player._xp = -4;
            }
            else if (DiceNumber < 11)
            {
                player._health -= ob.boulder5;
                player._xp = -1;
            }
        }
        private void HealThePlayer(Player player, int DiceNumber)
        {
            if (DiceNumber > 18)
            {
                player._health += 20;
                player._xp = 17;
            }
            else if (DiceNumber > 16)
            {
                player._health += 8;
                player._xp = 11;
            }
            else if (DiceNumber > 14)
            {
                player._health += 6;
                player._xp = 8;
            }
            else if (DiceNumber > 12)
            {
                player._health += 4;
                player._xp = 5;
            }
            else if (DiceNumber > 10)
            {
                player._health += 2;
                player._xp = 2;
            }
        }
    }

    class Obstacles
    {
        public int boulder1;
        public int boulder2;
        public int boulder3;
        public int boulder4;
        public int boulder5;
        public Obstacles()
        {
            boulder1 = 15;
            boulder2 = 6;
            boulder3 = 4;
            boulder4 = 2;
            boulder5 = 1;
        }
        //public void Damage(int diceNumber, Player player)
        //{
        //    player._health -= boulder1;
        //}
    }
}
