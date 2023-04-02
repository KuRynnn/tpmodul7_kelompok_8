using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_8
{
    internal class KuliahMahasiswa1302210059
    {
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:\\Users\\fadel\\source\\repos\\tpmodul7_kelompok_8\\tp7_2_1302210059.json");
            ListMatkulMahasiswa matkul = JsonSerializer.Deserialize<ListMatkulMahasiswa>(jsonString);

            for (int i = 0; i < matkul.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " + matkul.courses[i].name + " - " + matkul.courses[i].code);
            }
        }
    }
}
