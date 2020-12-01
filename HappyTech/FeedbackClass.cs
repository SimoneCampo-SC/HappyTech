/**
 * 
 * File: FeedbackClass.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This is the back-end class that houses the logic
 *              used in EditorForm.cs.
 *              
 */

namespace HappyTech
{
    static class FeedbackClass
    {
        /// <summary>
        /// Create the EditorForm at the specific position 
        /// </summary>
        /// <param name="direction">if it needs to move forward or backward</param>
        /// <param name="currentPosition">holds the current position</param>
        /// <returns></returns>
        public static FeedbackForm NextForm(string direction, int currentPosition)
        {
            FeedbackForm f;
            switch (direction)
            {
                case "forward":
                    f = new FeedbackForm((currentPosition + 1));
                    break;
                case "backward":
                    f = new FeedbackForm((currentPosition - 1));
                    break;
                default:
                    f = new FeedbackForm((currentPosition));
                    break;
            }
            return f;
        }
    }
}
