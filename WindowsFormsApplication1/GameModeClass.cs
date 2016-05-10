using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    abstract class GameModeClass
    {
        public string Name { get; private set; }
        public abstract Player player1 { get; set; }
        public abstract Player player2 { get; set; }
        public abstract Dictionary<string, Label> labelDictionary { get; set; }

        public GameModeClass()
        {
            Name = this.ToString().Split('.').LastOrDefault();
        }
        public abstract void Initialize();

        public abstract void Turn();
        public abstract void SkipTurn();
    }
}