using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_8
{
    internal class ListMatkulMahasiswa
    {
        public List<MataKuliah> courses { get; set; }
        public ListMatkulMahasiswa(List<MataKuliah> courses)
        {
            this.courses = courses;
        }
    }
}