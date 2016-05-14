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
        private int _xp = 0;
        public int xp
        {
            get { return _xp; }
            set
            {
                _xp += value;
                if (_xp > 100)
                    _xp = 100;
            }
        }
        public string Name { get; set; }
        public Player(string name)
        {
            Name = name;
            health = 20;
        }
        public Player(string name, int health)
        {
            
            Name = name;
            this.health = health;
        }
        public Player(string name, int health, int maxhealth)
        {
            Name = name;
            this.health = health;
            maxHealth = maxhealth;
        }
        //public int exp;
        public int turns
        {
            get;
            set;
        }
        private int _health;
        public int health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > maxHealth)
                {
                    _health = maxHealth;
                    value = _health;
                }
                else
                {
                    _health = value;
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
