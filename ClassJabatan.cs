using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUEnyang_8
{
    public class Jabatan
    {
        // Properti sesuai dengan kolom tabel Jabatan
        public string IdJabatan { get; set; }
        public string NamaJabatan { get; set; }

        // Constructor default
        public Jabatan() { }

        // Constructor dengan parameter
        public Jabatan(string idJabatan, string namaJabatan)
        {
            IdJabatan = idJabatan;
            NamaJabatan = namaJabatan;
        }

        // Method untuk menampilkan info jabatan
        public override string ToString()
        {
            return $"{IdJabatan} - {NamaJabatan}";
        }
    }
}

