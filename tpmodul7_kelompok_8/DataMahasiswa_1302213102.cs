using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_8
{
    internal class DataMahasiswa_1302213102
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\Materi Tel U\\Semester 4\\KPL TP\\TP KPL_MOD7_Kelompok\\tpmodul7_kelompok_8\\tp7_1_1302213102.json");
            ClassMahasiswa mahasiswa = JsonSerializer.Deserialize<ClassMahasiswa>(jsonString);
            Console.WriteLine("Nama : " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang);
            Console.WriteLine("NIM : " + mahasiswa.nim);
            Console.WriteLine("Fakultas : " + mahasiswa.fakultas);
        }
    }
}
