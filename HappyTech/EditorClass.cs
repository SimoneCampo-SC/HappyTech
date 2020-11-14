using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    static class EditorClass
    {
        
        public static EditorForm NextForm (int direction, int currentPosition)
        {
            EditorForm f;
            switch (direction)
            {
                case 1:
                    f = new EditorForm((currentPosition + 1));
                    break;
                case 0:
                    f = new EditorForm((currentPosition - 1));
                    break;
                default:
                    f = new EditorForm((currentPosition)); 
                    break;
            }
            return f;
        }
    }
}
