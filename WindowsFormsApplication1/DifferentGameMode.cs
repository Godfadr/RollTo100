using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DifferentGameMode : GameModeClass
    {
        public override Dictionary<string, Label> labelDictionary { get; set; }

        public override Player player1 { get; set; }

        public override Player player2 { get; set; }

        bool turn = true;

        private Dice dice = new Dice(1000000);

        public override void Initialize()
        {
            player1 = new Player("student", 10, int.MaxValue);
            player2 = new Player("profesor", 10, int.MaxValue);
        }

        public override void SkipTurn()
        {
            if (turn)
                NotTheGame(player1);
            else
                NotTheGame(player2);
        }

        public override void Turn()
        {
            if (turn)
                TheGame(player1);
            else
                TheGame(player2);
        }

        private void NotTheGame(Player player)
        {
            if (player.xp >= 0)
                player.health += 10;
            player.HPLabel.Text = player.health.ToString();
            if (player.Name == player1.Name)
                labelDictionary["turnLabel"].Text = "Turn: " + player2.Name;
            else
                labelDictionary["turnLabel"].Text = "Turn: " + player1.Name;
            turn = !turn;
        }

        private void TheGame(Player player)
        {
            int dicenumber = dice.DiceNumber;
            if (dicenumber > 685176)
            {
                player.health -= 5;
                player.xp = 10 + (int)(2 * player.turns);
            }
            else
            {
                int punishment = 5 + 5 * player.turns;
                if (player.health >= punishment)
                    player.health -= punishment;
                else
                {
                    punishment -= player.health;
                    player.health = 0;
                    player.xp = -punishment;
                }
            }
            finished(player);
            if (player.xp >= 0)
                player.health += 10;
            player.turns++;
            string i = player1.ToString();
            player.XPLabel.Text = player.xp.ToString();
            player.HPLabel.Text = player.health.ToString();
            if (player.Name == player1.Name)
                labelDictionary["turnLabel"].Text = "Turn: " + player2.Name;
            else
                labelDictionary["turnLabel"].Text = "Turn: " + player1.Name;
            turn = !turn;
        }

        private void finished(Player player)
        {
            if (player.xp >= 100)
            {
                RecordManager.SaveFile(new RecordSomethingIGuess(player.Name, player.turns),this.Name);
                MessageBox.Show("Player " + player.Name + " has won this fantastic game!");
            }
            else if (player.xp < 0)
            {
                MessageBox.Show("Player " + player.Name + " has lost this not so fantastic game! :(");
            }
        }
    }
}
