using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Dice
    {
        private int diceNumber;
        private int sidesOfDice { get; set; }
        private Random rand = new Random();
        public int DiceNumber
        {
            get
            {
                return this.diceNumber = rand.Next(1, sidesOfDice);
            }
            set { this.diceNumber = value; }
        }
        public Dice()
        {
            sidesOfDice = 6;
        }
        public Dice(int sidesOfDice)
        {
            this.sidesOfDice = sidesOfDice;
        }
    }
}
