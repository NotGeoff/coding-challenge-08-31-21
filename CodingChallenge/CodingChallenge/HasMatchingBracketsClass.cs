using System;

namespace CodingChallenge
{
    public static class HasMatchingBracketsClass
    {
        public static bool HasMatchingBrackets(string input)
        {
            var unmatchedBrackets = 0;
            foreach (var character in input)
            {
                switch (character)
                {
                    case '{':
                        unmatchedBrackets++;
                        break;
                    case '}':
                        if (unmatchedBrackets <= 0)
                            return false;
                        else
                            unmatchedBrackets--;
                        break;
                    //default case is not used
                }
            }
            return unmatchedBrackets == 0;
        }
    }
}