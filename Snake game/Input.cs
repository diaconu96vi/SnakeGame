using System;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    class Input
    {
        private static Hashtable keyTable = new Hashtable();

        public static bool KeyPress(Keys key)
        {
            //Return a key back to the class
            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }

        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
