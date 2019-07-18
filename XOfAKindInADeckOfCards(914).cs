public class Solution {
 public bool HasGroupsSizeX(int[] deck)
    {
        if (deck.Length <= 1) return false;
        Dictionary<int, int> nOfAKind = new Dictionary<int, int>();
        for (int i = 0; i < deck.Length; i++)
        {
            if (!nOfAKind.ContainsKey(deck[i]))
            {
                nOfAKind.Add(deck[i], 1);
            } else
            {
                nOfAKind[deck[i]] = nOfAKind[deck[i]] + 1;
            }
        }
        int numOfCopiesToHave = 2;
        while(numOfCopiesToHave <= nOfAKind[deck[0]])
        {
            bool result = true;
            foreach(KeyValuePair<int, int> item in nOfAKind)
            {
                if(item.Value != numOfCopiesToHave && item.Value % numOfCopiesToHave != 0)
                {
                    result = false; ;
                }
            }
            if(result == true)
            {
                return true;
            }
            numOfCopiesToHave++;
        }
        return false;
    }
}