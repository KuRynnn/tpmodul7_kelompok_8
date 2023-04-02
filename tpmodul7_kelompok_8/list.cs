using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_8
{
    internal class list
    {
        public List<MataKuliah> courses { get; set; }
        public list(List<MataKuliah> courses)
        {
            this.courses = courses;
        }
    }
}