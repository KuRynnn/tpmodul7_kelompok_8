using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_8
{
    internal class MataKuliah
    {
        public string code {  get; set; }
        public string name { get; set; }
        public MataKuliah(string code, string name)
        {
            this.code = code;
            this.name = name;
        }   
    }
}
