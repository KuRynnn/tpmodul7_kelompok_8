using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_8
{
    internal class DataMahasiswa_1302210130
    {
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:\\Users\\USER\\OneDrive\\Documents\\Code\\C#\\tpmodul7_kelompok_8\\tp7_1_1302210130.json");
            ContohClassMahasiswa mahasiswa = JsonSerializer.Deserialize<ContohClassMahasiswa>(jsonString);

            Console.WriteLine("Nama "+mahasiswa.nama.depan+" "+
                mahasiswa.nama.belakang+" dengan nim "+mahasiswa.nim+
                " dari fakultas "+mahasiswa.fakultas);
        }
    }
}
