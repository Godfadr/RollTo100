using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Player
    {
        
        public Label XPLabel;
        public Label HPLabel;
        public int maxHealth = 100;
        private int xp = 0;
        public int _xp
        {
            get { return xp; }
            set
            {
                xp += value;
                if (xp > 100)
                    xp = 100;
            }
        }
        public string Name { get; set; }
        public Player(string name)
        {
            Name = name;
            _health = 20;
        }
        public Player(string name, int health)
        {
            
            Name = name;
            _health = health;
        }
        public Player(string name, int health, int maxhealth)
        {
            Name = name;
            _health = health;
            maxHealth = maxhealth;
        }
        //public int exp;
        public int _turns
        {
            get;
            set;
        }
        private int Health;
        public int _health
        {
            get
            {
                return Health;
            }
            set
            {
                if (value < 0)
                {
                    Health = 0;
                }
                else if (value > maxHealth)
                {
                    Health = maxHealth;
                    value = Health;
                }
                else
                {
                    Health = value;
                }
            }
        }
        // public void Damage(int dmg)
        // {
        //     _health -= dmg;
        // }
        //public void Damage_(Obstacles Boulder)
        //{
        //    health_ -= Boulder.Boulder2;
        //}
    }
}
