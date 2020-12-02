/**
 * 
 * File: FeedbackClass.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This is the Feedback back-end class, created to guest
 *              the FeedbackForm logic.
 *              used in FeedbackForm.cs.
 *              
 */

namespace HappyTech
{
    static class FeedbackClass
    {

        // Defines the objects which can be of the type Direction
        public enum Direction
        {
            Forward,
            Backward,
            Current
        }

        /// <summary>
        /// Create a new feedback form diplaying either the next or the previous template in the list
        /// In case the Form can't move neither forward nor backward, it will stay in the current position
        /// </summary>
        /// <param name="direction"> Direction user is travelling in list: Forward, Backward, Current. </param>
        /// <param name="currentPosition"> The applicant position in the list: Integer </param>
        /// <returns></returns>
        /// 
        public static FeedbackForm NextForm(Direction direction, int currentPosition)
        {
            FeedbackForm _instance;
         
            switch (direction)
            {
                // In case direction is Forward, the next feedback form will be one step ahead
                case Direction.Forward:
                    _instance = new FeedbackForm((currentPosition + 1));
                    break;

                // In case direction is Backward, the next feedback form will be one step back
                case Direction.Backward:
                    _instance = new FeedbackForm((currentPosition - 1));
                    break;

                // In case direction is Current, the next feedback form will be the same
                case Direction.Current:
                    _instance = new FeedbackForm((currentPosition));
                    break;

                // The first postition
                default:
                    _instance = new FeedbackForm(0);
                    break;
            }

            return _instance;
        }
    }
}
