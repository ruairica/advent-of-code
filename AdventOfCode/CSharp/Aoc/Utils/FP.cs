namespace Utils;
// File Parser
public static class FP
{
    public static string ReadFile(string path) =>
        File.ReadAllText(path)
            .Replace("\r\n", "\n") // standardize line breaks
            .Trim();

    public static string[] ReadLines(string path) =>
        ReadFile(path).Split("\n");

    public static List<List<int>> ReadAsGrid(string path) =>
        ReadLines(path)
              .Select(x => x.Select(y => int.Parse(y.ToString())).ToList())
              .ToList();

    public static List<List<char>> ReadAsCharGrid(string path) =>
        ReadLines(path)
            .Select(x => x.Select(y => y).ToList())
            .ToList();
}
