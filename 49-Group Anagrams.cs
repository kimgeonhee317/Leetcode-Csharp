public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IList<IList<string>> answerList = new List<IList<string>>();
        Dictionary<string, List<string>> hashtable = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            string key = new string(str.OrderBy(x => x).ToArray()); //Get key by sorting

            if (!hashtable.ContainsKey(key)) // Add key and value if there is no key
            {
                hashtable.Add(key, new List<string>());
                hashtable[key].Add(str);
            }
            else // Add value to list if there is key already
            {
                hashtable[key].Add(str);
            }
        }

        foreach (string key in hashtable.Keys)
        {
            answerList.Add(hashtable[key]);
        }

        return (IList<IList<string>>)answerList;
    }
}