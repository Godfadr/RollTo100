using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class RaceTo100 : GameModeClass
    {
        private Dice d = new Dice(11);
        private bool turn = true;
        int healthfordamage = 0;
        public override Player player1 { get; set; }

        public override Player player2 { get; set; }

        public override Dictionary<string, Label> labelDictionary
        {
            get; set;
        }
        

        public void GameMode1(Player player, int action)
        {
          int yourChosenAction = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                int diceNumber = d.DiceNumber;
                Console.WriteLine(diceNumber.ToString());
                if (d.DiceNumber >= 6 + player._turns)
                    player._health += 15;
                else if (d.DiceNumber <= 5 + player._turns)
                    player._health -= 10;
            player._xp += 5 + 5 * player._turns;
                player._turns++;
            }
            labelDictionary[player.Name + "HP"].Text = player._health.ToString();
            labelDictionary[player.Name + "XP"].Text = player._xp.ToString();

        }
        public override void Turn()
        {
            if (turn)
            {
                GameMode1(player1, 1);
                
                labelDictionary["turnLabel"].Text = "Turn: " + player1.Name;
                finished(player1._health, player1._xp, player1);
                turn = !turn;
                return;
            }
            GameMode1(player2, 1);
            labelDictionary["turnLabel"].Text = "Turn: " + player2.Name;
            finished(player2._health, player2._xp, player2);
            turn = !turn;
        }

        public void finished(int hp, int xp, Player player)
        {
            if (hp >= 100 || xp >= 100)
            {
                MessageBox.Show("Player " + player.Name + " has won!");
            }
        }

        public override void SkipTurn()
        {
            if (turn)
            {
                GameMode1(player1, 0);
                labelDictionary["turnLabel"].Text = "Turn: " + player2.Name;
                turn = !turn;
                return;
            }
            GameMode1(player2, 0);
            labelDictionary["turnLabel"].Text = "Turn: " + player1.Name;
            turn = !turn;
        }

        public override void Initialize()
        {
            player1 = new Player("Player1");
            player2 = new Player("Player2");
        }
        
    }
}
