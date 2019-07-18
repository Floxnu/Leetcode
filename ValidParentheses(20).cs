public class Solution {
    public bool IsValid(string s) {
        if(s.Length == 0) { return true; }
        if (s.Length < 2) { return false; }
        else
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>();
            bracketPairs.Add('(', ')');
            bracketPairs.Add('{', '}');
            bracketPairs.Add('[', ']');
            Stack<char> parenStack = new Stack<char>();
            parenStack.Push(s[0]);
            for(int i = 1; i < s.Length; i++)
            {
                char charAtIndex = s[i];
                if (bracketPairs.ContainsKey(charAtIndex))
                {
                    parenStack.Push(charAtIndex);
                }
                else
                {
                    if(parenStack.Count > 0)
                    {
                        char currentChar = parenStack.Peek();
                        char outChar;
                        bracketPairs.TryGetValue(currentChar, out outChar);
                        if (outChar == charAtIndex)
                        {
                            parenStack.Pop();
                        }
                        else
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if(parenStack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}