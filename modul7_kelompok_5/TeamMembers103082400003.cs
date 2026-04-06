using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class TeamMembers103082400003
{
    public List<Members>? members { get; set; }

    public class Members
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? gender { get; set; }
        public int? age { get; set; }
        public string? nim { get; set; }
    }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_2_103082400003.json");

        TeamMembers103082400003 data = JsonSerializer.Deserialize<TeamMembers103082400003>(jsonString)!;
        Console.WriteLine("\n========== Team Members List ==========");

        int i = 1;
        foreach (var member in data.members)
        {
            Console.WriteLine($"{i}. Name   : {member.firstName} {member.lastName}");
            Console.WriteLine($"   Gender : {member.gender}");
            Console.WriteLine($"   Age    : {member.age}");
            Console.WriteLine($"   NIM    : {member.nim}");
            i++;
        }
    }
}