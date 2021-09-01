namespace CodingChallenge
{
    public static class HasMatchingBracketsClass
    {
        /// <summary>
        /// Determines whether or not characters in a string have matching brackets. Meaning for every '{' bracket there is a
        /// corresponding '}' bracket.
        /// </summary>
        /// <param name="input">The string to search for matching bracket pairs.</param>
        /// <returns>Return true if the characters in the string have matching brackets, and false if not.</returns>
        public static bool HasMatchingBrackets(string input)
        {
            // A running count of unmatched opening brackets.
            var unmatchedBrackets = 0;
            foreach (var character in input)
            {
                switch (character)
                {
                    case '{':
                        // We have encountered an opening bracket. Increment the counter.
                        unmatchedBrackets++;
                        break;
                    case '}':
                        if (unmatchedBrackets <= 0)
                            // We have encountered a closing bracket that does not have a matching opening bracket,
                            // therefore the string is invalid.
                            return false;
                        else
                            // We have encountered a closing bracket that does have a matching opening bracket.
                            // Decrement the counter.
                            unmatchedBrackets--;
                        break;
                    // The default case is that we encounter any character other than an opening or closing bracket.
                    // Since the action in this case is to do nothing, I have excluded the default case.
                }
            }
            //If there no are no remaining opening brackets to be matched to a closing bracket, then the string is valid.
            //If there are remaining opening brackets to be matched to a closing bracket, then the string is not valid.
            return unmatchedBrackets == 0;
        }
    }
}