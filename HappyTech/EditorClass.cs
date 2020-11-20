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
        /// <param name="direction">if it needs to move forward or backward</param>
        /// <param name="currentPosition">holds the current position</param>
        /// <returns></returns>
        public static EditorForm NextForm(string direction, int currentPosition)
        {
            EditorForm f;
            switch (direction)
            {
                case "forward":
                    f = new EditorForm((currentPosition + 1));
                    break;
                case "backward":
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
