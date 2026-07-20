public class Solution {
    public string Encode(IList<string> strs) {
        string result = String.Empty;

        foreach (var str in strs) {
            result = String.Concat(result, $"{str.Length}={str}");
        }
        return result;
    }

    public List<string> Decode(string s) {
        List<string> output = new();
        var indexInitial = 0;

        if (String.IsNullOrEmpty(s)) {
            //output.Add("");
            return output;
        }

        while (indexInitial < s.Length) {
            var index = s.IndexOf('=', indexInitial);
            if (int.TryParse(s.Substring(indexInitial, index - indexInitial), out var largo)) {
                var word = s.Substring(index + 1, largo);
                indexInitial = index + largo + 1;
                output.Add(word);
            } else

                return output;
        }

        return output;
    }
}
