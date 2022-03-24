namespace Library
{
    public static class StringExtensions
    {
        public static IEnumerable<String> SplitInParts(this String s, Int32 partLength)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s));
            if (partLength <= 0)
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));

            for (var i = 0; i < s.Length; i += partLength)
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
        }

        public static void FindPermutations(List<string> permutations, char[] str, int index, int n)
        {
            if (index >= n)
            {
                permutations.Add(new string(str));
                return;
            }

            for (int i = index; i < n; i++)
            {
                bool check = shouldSwap(str, index, i);
                if (check)
                {
                    swap(str, index, i);
                    FindPermutations(permutations, str, index + 1, n);
                    swap(str, index, i);
                }
            }
        }

        static bool shouldSwap(char[] str, int start, int curr)
        {
            for (int i = start; i < curr; i++)
                if (str[i] == str[curr])
                    return false;
            return true;
        }

        static void swap(char[] str, int i, int j)
        {
            char c = str[i];
            str[i] = str[j];
            str[j] = c;
        }

    }
}