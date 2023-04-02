using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_8
{
    internal class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
        public Nama(string depan, string belakang) 
        {
            this.depan = depan;
            this.belakang = belakang;
        }
    }
}
