using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Obstacles
    {
        private int boulder1; private int boulder2;
        public Obstacles()
        {
            boulder1 = 10;
            boulder2 = 5;
        }
        public int Boulder2
        {
            set
            {
                //  this.Boulder = boulder_;
            }
            get
            {
                return boulder1;
            }
        }
    }
    class SmallObstacles : Obstacles
    {
        private double boulder3;
        public SmallObstacles()
        {
            boulder3 = 0.4;
        }
    }
    public class Player
    {
        public void PrintStats()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Player");
            Console.WriteLine("Health" + _health);
        }
        public int xp = 0;
        public string Name { get; set; }
        public Player(string name)
        {
            Name = name;
            _health = 20;
        }
        //public int exp;
        public int Turns
        {
            get;
            set;
        }
        public int Health;
        public int _health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value < 0)
                {
                    Health = 0;
                }
                else if (value > 100)
                {
                    Health = 100;
                    value = Health;
                }
                else
                {
                    Health = value;
                }
            }
        }
        public void Damage(int dmg)
        {
            _health -= dmg;
        }
        //public void Damage_(Obstacles Boulder)
        //{
        //    health_ -= Boulder.Boulder2;
        //}
    }
    public class Dice
    {
        private int diceNumber;
        public int DiceNumber
        {
            get
            {
                Random rand = new Random();
                return this.diceNumber = rand.Next(1, 11);
            }
            set { this.diceNumber = value; }
        }
    }
    public class Program
    {
        static Dice d = new Dice();
        //static int turn = 0;

        public static void GameMode1(Player player, int action)
        {
            Console.WriteLine("It's " + player.Name + " turn.");
            Console.WriteLine("Choose action (1 - Roll the dice, 2 - Skip turn)");
            int yourChosenAction = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                int diceNumber = d.DiceNumber;
                Console.WriteLine(diceNumber.ToString());
                if (d.DiceNumber >= 6 + player.Turns)
                    player._health += 15;
                else if (d.DiceNumber <= 5 + player.Turns)
                    player._health -= 10;
                Console.WriteLine(player.Name + "'s health is " + player._health);
                Console.WriteLine(player.Name + "'s experience is " + player.xp);
                player.xp += 5 + 5 * player.Turns;
                player.Turns++;
            }
            Console.WriteLine(player.Name + " health is " + player._health);
            Console.WriteLine();
        }
        public static void GameMode2(Player player)
        {

        }

        static void Main(string[] args)
        {
            //Console.WriteLine("There's a winner!");
            /*// Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Green;
            //int diceNumber = d.DiceNumber;
            //Player Player1 = new Player("player1");
            //Player Player2 = new Player("player2");
            //Player Player3 = new Player("player3");
            //while (Player1.xp < 100 && Player1.health_ < 100 && Player2.xp < 100 && Player2.health_ < 100 && Player3.xp < 100 && Player3.health_ < 100)
            //{
            //    Console.WriteLine($"turn is {turn}");
            //    switch (turn)
            //    {
            //        case 0: Turn(Player1); break;
            //        case 1: Turn(Player2); break;
            //        case 2: Turn(Player3); break;
            //        default:
            //            break;
            //    }
            //    //if (turn)
            //    //    Turn(Player1); //giving the method the player1
            //    //else
            //    //    Turn(Player2);
            //    //turn = !turn; //changing true to false and vise versa
            //    turn++;
            //    if (turn == 3)
            //        turn = 0;
        //}//No magic happend here
             Console.WriteLine("Choose action");
        int yourChosenAction2 = Convert.ToInt32(Console.ReadLine());
        if (yourChosenAction2 == 1)
        {
            Dice d3 = new Dice();
            int diceNumber3 = d.DiceNumber;
            Console.WriteLine(diceNumber.ToString());
        }
            // Convert.ToInt32();
            //if (i == 1)
            {
                //dice roll;
            }

            //10 sided dice
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello, what's up!");

                Player Player1 = new Player();
                Player1.health_ += 200;
                Console.WriteLine("Player1 showers with healing potions");
                Console.WriteLine("Player1's health is " + Player1.health_);
                Player Player2 = new Player();
                Player2.Damage(120);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Player2 gets stabbed by an icicle");
                Console.WriteLine("Player2's health is " + Player2.health_);
                Obstacles b = new Obstacles();
                Player1.Damage_(b);
                Console.WriteLine("Player1's health is " + Player1.health_);
                SmallObstacles b4 = new SmallObstacles();
                Player2.health_ += 200;
                Player2.Damage_(b4);
                Console.WriteLine("Player2's health is " + Player2.health_);
                //Player1.PrintStats();
                Player2.PrintStats();
                Console.ReadKey();
        */
        }
    }
}
