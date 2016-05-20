using System;

namespace Rts.Interview
{
    /// <summary>
    /// Interface for the test problem set.
    /// </summary>
    public interface ITestProblems
    {
        /// <summary>
        /// Organizes the given array of <paramref name="numbers"/> by occurrences that are above or
        /// below <paramref name="input"/>.
        /// </summary>
        /// <param name="input">The number to compare against i.e. number < input < number</param>
        /// <param name="numbers">The numbers to count. <code>null</code> is invalid.</param>
        /// <returns>Tuple containing the counted numbers or <code>null</code> on bad input.  The first
        /// value contains the "below" count, the second value the "above" count.</returns>
        Tuple<int, int> CountNumbers(int input, int[] numbers);

        /// <summary>
        /// Rotates the <paramref name="input"/> by the given <paramref name="rotateCount"/> amount such
        /// that the overflow appears at the beginning of the new string.  The string cannot rotate backwards 
        /// or past the end of the string.
        /// </summary>
        /// <remarks>
        ///     "MyString" rotated by 2 is "ngMyStri"
        ///      01234567                   67012345
        ///      The original 0th index character is rotated by 2 positions.
        /// </remarks>
        /// <param name="input">The string to rotate.</param>
        /// <param name="rotateCount">The amount by which to rorate the string.</param>
        /// <returns>The rotated string or <code>null</code> on invalid input.</returns>
        String RotateString(String input, int rotateCount);
    }
}
