using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_8
{
    internal class DataMahasiswa1302210059
    {

        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:\\Users\\fadel\\source\\repos\\tpmodul7_kelompok_8\\tp7_1_1302210059.json");
            ContohClassMahasiswa mahasiswa = JsonSerializer.Deserialize<ContohClassMahasiswa>(jsonString);

            Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + 
                " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        }
    }
}
