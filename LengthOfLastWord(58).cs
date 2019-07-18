public class Solution {
    public int LengthOfLastWord(string s) {
        string trimmedWord = s.TrimEnd();
        if(trimmedWord.Length < 1) { return 0; }
        if(trimmedWord.Length == 1){return 1;}
        string[] splitString = trimmedWord.Split(' ');
        if(splitString.Length < 1) { return 0; }
        return splitString[splitString.Length - 1].Length;
    }
}