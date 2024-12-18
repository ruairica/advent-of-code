using System.Text.RegularExpressions;

namespace Utils;

public static class Helpers
{
    public static double Median<T>(this IEnumerable<T> items) where T : struct, IComparable<T>
    {
        ArgumentNullException.ThrowIfNull(items);

        var sortedList = items.OrderBy(x => x).ToList();
        int count = sortedList.Count;
        int middleIndex = count / 2;

        if (count % 2 == 0)
        {
            dynamic value1 = sortedList[middleIndex - 1];
            dynamic value2 = sortedList[middleIndex];
            return (value1 + value2) / 2.0;
        }

        return Convert.ToDouble(sortedList[middleIndex]);
    }

    public static IEnumerable<(T val, int index)> Index<T>(this IEnumerable<T> list) =>
        list.Select((x, i) => (x, i));

    public static int ConvertToDecimal(List<int> binary)
    {
        return binary.Select((t, m) => t * (int)Math.Pow(2, binary.Count - 1 - m)).Sum();
    }

    public static List<int> Nums(this string input) => Regex.Matches(input, @"-?\d+").Select(x => int.Parse(x.Value)).ToList();

    public static List<long> Longs(this string input) => Regex.Matches(input, @"-?\d+").Select(x => long.Parse(x.Value)).ToList();
}
