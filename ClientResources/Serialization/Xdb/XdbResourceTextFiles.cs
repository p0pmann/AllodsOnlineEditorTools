namespace AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;

public sealed class XdbResourceTextFiles(string resourcePath, Func<string, string?> readText)
{
    private readonly Dictionary<string, string> _files = new(StringComparer.OrdinalIgnoreCase);
    public IReadOnlyDictionary<string, string> Files => _files;

    public string GetHref(string field, string sourcePath)
    {
        if (string.IsNullOrEmpty(sourcePath))
        {
            return "";
        }

        var text = readText(sourcePath);
        if (text is null)
        {
            return "/" + sourcePath;
        }

        var normalized = resourcePath.Replace('\\', '/');
        var slash = normalized.LastIndexOf('/');
        var directory = slash < 0 ? "" : normalized[..(slash + 1)];
        var stem = Path.GetFileNameWithoutExtension(normalized[(slash + 1)..]);
        var suffix = string.IsNullOrEmpty(field) ? "Text" :
            new string(field.Select(c => char.IsAsciiLetterOrDigit(c) || c is '_' or '-' ? c : '_').ToArray());
        suffix = char.ToUpperInvariant(suffix[0]) + suffix[1..];
        var prefix = $"{stem}.{suffix}";
        var name = prefix + ".txt";
        var index = 2;
        while (!_files.TryAdd(directory + name, text))
        {
            name = $"{prefix}{index++}.txt";
        }

        return name;
    }
}
