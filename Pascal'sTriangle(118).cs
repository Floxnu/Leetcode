public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> result = new List<IList<int>>();
        if(numRows == 0) return result;
        List<int> current = new List<int>();
        current.Add(1);
        result.Add(current);
        if (numRows == 1)
        {
            return result;
        }
        for (int i = 1; i < numRows; i++)
        {
            int previuosLayerIndex = 0;
            List<int> currentLayer = new List<int>();
            while(previuosLayerIndex <= result[i - 1].Count)
            {
                int numberToAdd = 0;
                if(previuosLayerIndex - 1 >= 0)
                {
                    numberToAdd += result[i - 1][previuosLayerIndex - 1];
                }
                if(previuosLayerIndex < result[i - 1].Count)
                {
                    numberToAdd += result[i - 1][previuosLayerIndex];
                }
                currentLayer.Add(numberToAdd);
                previuosLayerIndex++;
            }
            result.Add(currentLayer);
        }
        return result;
  
    }
}