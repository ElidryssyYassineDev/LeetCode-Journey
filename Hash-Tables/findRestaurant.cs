public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        List<string> result = new List<string>();
        Dictionary<string, int> hashMap = new Dictionary<string, int>();

        int minIndex = int.MaxValue;

        // Stocker les restaurants de list1 avec leur index
        for (int i = 0; i < list1.Length; i++)
        {
            hashMap[list1[i]] = i;
        }

        // Parcourir list2
        for (int i = 0; i < list2.Length; i++)
        {
            if (hashMap.ContainsKey(list2[i]))
            {
                int sum = i + hashMap[list2[i]];

                if (sum < minIndex)
                {
                    minIndex = sum;
                    result.Clear();
                    result.Add(list2[i]);
                }
                else if (sum == minIndex)
                {
                    result.Add(list2[i]);
                }
            }
        }

        return result.ToArray();
    }
}