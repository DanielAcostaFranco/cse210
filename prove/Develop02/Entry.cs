using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public string ToLine()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    public static Entry FromLine(string line)
    {
        string[] parts = line.Split('|');
        Entry e = new Entry();
        e._date = parts[0];
        e._prompt = parts[1];
        e._response = parts[2];
        return e;
    }
}
