using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    static class EditorClass
    {
        
        public static Form3 NextForm (int direction, int currentPosition)
        {
            Form3 f;
            switch (direction)
            {
                case 1:
                    f = new Form3((currentPosition + 1));
                    break;
                case 0:
                    f = new Form3((currentPosition - 1));
                    break;
                default:
                    f = new Form3((currentPosition)); 
                    break;
            }
            return f;
        }
    }
}
