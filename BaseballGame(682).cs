public class Solution {
    public int CalPoints(string[] ops) {
        int sum = 0;
        if(ops.Length < 1)
        {
            return sum;
        }
        List<int> validScores = new List<int>();
        foreach(string s in ops)
        {
            int currentScore = 0;
            if(int.TryParse(s, out currentScore))
            {
                sum += currentScore;
                validScores.Add(currentScore);
            } else if(s == "D")
            {
                sum += (validScores[validScores.Count - 1] * 2);
                validScores.Add((validScores[validScores.Count - 1] * 2));
            } else if(s == "C")
            {
                sum -= validScores[validScores.Count - 1];
                validScores.RemoveAt(validScores.Count - 1);
            } else if(s == "+")
            {
                int currentIndex = validScores.Count - 1;
                int loopNum = 0;
                while (loopNum < 2)
                {
                    if(validScores.Count > currentIndex && currentIndex >= 0)
                    {
                        currentScore += validScores[currentIndex];
                    }
                    currentIndex--;
                    loopNum++;
                }
                sum += currentScore;
                validScores.Add(currentScore);
            }
        }
        return sum;
    }
}