using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class ScriptureLoader
{
    public static List<Scripture> LoadScriptures(string filename)
    {
        string jsonString = File.ReadAllText(filename);

        var data = JsonSerializer.Deserialize<ScriptureData>(jsonString, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        List<Scripture> scriptures = new List<Scripture>();

        foreach (var s in data.Scriptures)
        {
            Reference reference;

            if (s.VerseEnd.HasValue && s.VerseEnd.Value > s.VerseStart)
                reference = new Reference(s.Book, s.Chapter, s.VerseStart, s.VerseEnd.Value);
            else
                reference = new Reference(s.Book, s.Chapter, s.VerseStart);

            scriptures.Add(new Scripture(reference, s.Text));
        }

        return scriptures;
    }

    private class ScriptureData
    {
        public List<ScriptureItem> Scriptures { get; set; }
    }

    private class ScriptureItem
    {
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int VerseStart { get; set; }
        public int? VerseEnd { get; set; }
        public string Text { get; set; }
    }
}