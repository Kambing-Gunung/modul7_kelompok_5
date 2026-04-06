using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class GlossaryItem103082400003
{
    public Glossary glossary { get; set; }

    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_3_103082400003.json");

        GlossaryItem103082400003 data = JsonSerializer.Deserialize<GlossaryItem103082400003>(jsonString)!;

        Console.WriteLine("\n========== GLOSSARY DATA ==========");
        Console.WriteLine("Title          : " + data.glossary.title);
        Console.WriteLine("GlossDiv Title : " + data.glossary.GlossDiv.title);
        Console.WriteLine("GlossTerm      : " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
        Console.WriteLine("Acronym        : " + data.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
        Console.WriteLine("Definition     : " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);

        Console.WriteLine("\nSee Also :");
        foreach (var item in data.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso)
        {
            Console.WriteLine("- " + item);
        }
    }
}