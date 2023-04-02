using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_8
{
    internal class DataMahasiswa_1302213039
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Telkom\\Semester 4\\KPL\\tp7\\tpmodul7_kelompok_8\\tp7_1_1302213039.json");
            ClassMahasiswa mahasiswa = JsonSerializer.Deserialize<ClassMahasiswa>(jsonString);

            Console.WriteLine("Nama " + mahasiswa.nama.depan +" "+ mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        }
    }
}
