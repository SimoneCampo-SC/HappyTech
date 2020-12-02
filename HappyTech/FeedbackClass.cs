/**
 * 
 * File: FeedbackClass.cs
 * 
 * Author 1: Campo, Simone. 1911840
 * Course: BEng (Hons) Computer Science, Year 2 Trimester 1
 * 
 * Summary:     This is the back-end class that houses the logic
 *              used in FeedbackForm.cs.
 *              
 */

namespace HappyTech
{
    static class FeedbackClass
    {

        public enum Direction
        { 
            Forward,
            Backward,
            Current
        }

        /// <summary>
        /// 
        ///     Create the next FeedbackForm.cs instance depending
        ///     on the direction the user is going.
        /// 
        /// </summary>
        /// <param name="direction"> Direction user is travelling in list: Forward, and Backward. </param>
        /// <param name="currentPosition"> The applicant position in the list: Integer </param>
        /// <returns></returns>
        public static FeedbackForm NextForm( Direction direction, int currentPosition )
        {
            FeedbackForm instance_FeedbackForm;

            switch ( direction )
            {
                case Direction.Forward:

                    // Next position.
                    instance_FeedbackForm = new FeedbackForm( ( currentPosition + 1 ) );

                    break;

                case Direction.Backward:

                    // Previous position.
                    instance_FeedbackForm = new FeedbackForm( ( currentPosition - 1 ) );

                    break;

                case Direction.Current:

                    // Remain the same position.
                    instance_FeedbackForm = new FeedbackForm( ( currentPosition ) );

                    break;

                default:

                    // If none other, start position.
                    instance_FeedbackForm = new FeedbackForm( 0 );

                    break;
            }

            return instance_FeedbackForm;
        }
    }
}
