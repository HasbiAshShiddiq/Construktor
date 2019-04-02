using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constuctor
{
    class Mahasiswa
    {
        // Constructor Default
        public Mahasiswa()
        {

        }

        //Constructor Dengan 2 Parameter
        public Mahasiswa(string nim, string nama)
        {
            Nim = nim;
            Nama = nama;
        }

        //Properties
        public string Nim { get; set; }
        public string Nama { get; set; }
    }
}
