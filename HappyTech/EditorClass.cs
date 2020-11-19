using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    static class EditorClass
    {
        /// <summary>
        /// Create the EditorForm at the specific position 
        /// </summary>
        /// <param name="direction">if it needs to move forward</param>
        /// <param name="currentPosition">if it needs to move backward</param>
        /// <returns></returns>
        public static EditorForm NextForm(int direction, int currentPosition)
        {
            EditorForm f;
            // if direction is 1, it moves forward
            // if direction is 0, it moves backward
            // default, just in the same position
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
