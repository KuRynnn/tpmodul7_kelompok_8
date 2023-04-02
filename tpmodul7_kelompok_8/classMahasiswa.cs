using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_8
{
    internal class classMahasiswa
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }
        public classMahasiswa(Nama nama, int nim, string fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }
    }
}