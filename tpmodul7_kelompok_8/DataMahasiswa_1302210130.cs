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
        public string link;
        public DataMahasiswa_1302210130(string link) 
        {
            this.link = link;
        }
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText(this.link);
            ContohClassMahasiswa mahasiswa = JsonSerializer.Deserialize<ContohClassMahasiswa>(jsonString);

            Console.WriteLine("Nama "+mahasiswa.nama.depan+" "+
                mahasiswa.nama.belakang+" dengan nim "+mahasiswa.nim+
                " dari fakultas "+mahasiswa.fakultas);
        }
    }
}
