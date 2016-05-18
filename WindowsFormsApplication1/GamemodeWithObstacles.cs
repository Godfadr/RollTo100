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
            player1 = new Player("student", 50);
            player2 = new Player("profesor", 50);
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
                player1.turns++;
                labelDictionary["turnLabel"].Text = "Turn: " + player2.Name;
                finished(player1);
            }
            else
            {
                DamageThePlayer(player2, DiceNumber);
                HealThePlayer(player2, DiceNumber);
                player2.turns++;
                labelDictionary["turnLabel"].Text = "Turn: " + player1.Name;
                finished(player2);
            }
            turn = !turn;
        }
        private void finished(Player player)
        {
            player.HPLabel.Text = player.health.ToString();
            player.XPLabel.Text = player.xp.ToString();

            if (player.health == 100)
            {
                SaveFileManager.Save(player.Name, player.turns, this.Name);
                //DataBaseManager.SaveFile(new RecordSomethingIGuess(player.Name, player.turns), this.Name);
                MessageBox.Show("Player " + player.Name + " has won!");
            }
        }
        private void DamageThePlayer(Player player, int DiceNumber)
        {
            if (DiceNumber < 3)
            {
                player.health -= ob.boulders[0];
                player.xp = -15;
            }
            else if (DiceNumber < 5)
            {
                player.health -= ob.boulders[1];
                player.xp = -10;
            }
            else if (DiceNumber < 7)
            {
                player.health -= ob.boulders[2];
                player.xp = -7;
            }
            else if (DiceNumber < 9)
            {
                player.health -= ob.boulders[3];
                player.xp = -4;
            }
            else if (DiceNumber < 11)
            {
                player.health -= ob.boulders[4];
                player.xp = -1;
            }
        }
        private void HealThePlayer(Player player, int DiceNumber)
        {
            if (DiceNumber > 18)
            {
                player.health += 20;
                player.xp = 17;
            }
            else if (DiceNumber > 16)
            {
                player.health += 8;
                player.xp = 11;
            }
            else if (DiceNumber > 14)
            {
                player.health += 6;
                player.xp = 8;
            }
            else if (DiceNumber > 12)
            {
                player.health += 4;
                player.xp = 5;
            }
            else if (DiceNumber > 10)
            {
                player.health += 2;
                player.xp = 2;
            }
        }
    }

    class Obstacles
    {
        public List<int> boulders = new List<int>(); // Using list, because it's dynamic, not like an array
        public Obstacles()
        {
            boulders.AddRange(new List<int> { 15, 6, 4, 2, 1 });
        }
        public Obstacles(List<int> intList)
        {
            boulders.AddRange(intList);
        }
        //public void Damage(int diceNumber, Player player)
        //{
        //    player._health -= boulder1;
        //}
    }

    class SmallObstacles : Obstacles
    {
        List<int> smallObstacles = new List<int>();

        private SmallObstacles()
        {
            boulders = boulders.OrderBy(t => t).Reverse().ToList(); //sort list from highest to lowest
            for (int i = 0; i < boulders.Count / 2.5; i++)//40% smallest Obstacles of Obstacles
            {
                smallObstacles.Add(boulders[i]);
            }
        }
    }
    class BigObstacles : Obstacles
    {
        List<int> bigObstacles = new List<int>();

        private BigObstacles()
        {
            boulders = boulders.OrderBy(t => t).Reverse().ToList(); //sort list from highest to lowest
            for (int i = 0; i > boulders.Count / 2.5; i++)//60% biggest Obstacles of Obstacles
            {
                bigObstacles.Add(boulders[i]);
            }
        }
    }
}
