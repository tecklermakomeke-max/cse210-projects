using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Add(Entry e)
    {
        _entries.Add(e);
    }

    public void Display()
    {
        foreach(var e in _entries)
        {
            e.Display();
        }
    }

    public void Save(string f)
    {
        using(StreamWriter w = new StreamWriter(f))
        {
            foreach(var e in _entries)
            {
                w.WriteLine($"{e._date}|{e._prompt}|{e._text}");
            }
        }
    }

    public void Load(string f)
    {
        _entries.Clear();
        foreach(string line in File.ReadAllLines(f))
        {
            var p = line.Split("|");
            _entries.Add(new Entry{_date=p[0], _prompt=p[1], _text=p[2]});
        }
    }
}