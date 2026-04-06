using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class Matakuliah
{
    public string? code { get; set; }
    public string? name { get; set; }
}
public class DataMahasiswa103082400003
{
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public string? gender { get; set; }
    public int? age { get; set; }
    public Address? address { get; set; }
    public List<Matakuliah>? courses { get; set; }

    public class Address
    {
        public string? streetAddress { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
    }

    

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_1_103082400003.json");

        DataMahasiswa103082400003 data = JsonSerializer.Deserialize<DataMahasiswa103082400003>(jsonString)!;

        Console.WriteLine(
            "\n========== Data Mahasiswa ==========" + 
            "\n" +
            $"Name    : {data.firstName} {data.lastName}\n" +
            $"Gender  : {data.gender}\n" +
            $"Age     : {data.age}\n\n" +
            $"Address : \n" +
            $"  Street : {data.address.streetAddress}\n" +
            $"  City   : {data.address.city}\n" +
            $"  State  : {data.address.state}\n\n" +
            $"Courses List : "
            );
        
        int i = 1;
        foreach (var course in data.courses)
        {
            Console.WriteLine($"{i}. Kode : {course.code}");
            Console.WriteLine($"   Nama : {course.name}");
            i++;
        }
    }
}