using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class DataMahasiswa1201230011
{
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public string? gender { get; set; }
    public int? age { get; set; }
    public Address? address { get; set; }
    public List<Courses>? courses { get; set; }

    public class Address
    {
        public string? streetAddress { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
    }

    public class Courses
    {
        public string? kode { get; set; }
        public string? nama { get; set; }
    }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_1_1201230011.json");

        DataMahasiswa1201230011 data = JsonSerializer.Deserialize<DataMahasiswa1201230011>(jsonString)!;

        Console.WriteLine(
            "\n========== Data Mahasiswa ==========" + 
            "\n" +
            $"Name {data.firstName} {data.lastName}\n" +
            $"Gender {data.gender}\n" +
            $"Age {data.age}\n\n" +
            $"Address: \n" +
            $"  Street {data.address.streetAddress}\n" +
            $"  City {data.address.city}\n" +
            $"  State {data.address.state}\n\n" +
            $"Courses:"
            );

        int i = 1;
        foreach (var course in data.courses)
        {
            Console.WriteLine($"{i}. Kode {course.kode}");
            Console.WriteLine($"   Nama {course.nama}");
            i++;
        }
    }
}