using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUEnyang_8
{
    public class KategoriKue
    {
        // Properti sesuai tabel
        public string IdKategori { get; set; }
        public string NamaKategori { get; set; }

        // Constructor default
        public KategoriKue() { }

        // Constructor dengan parameter
        public KategoriKue(string idKategori, string namaKategori)
        {
            IdKategori = idKategori;
            NamaKategori = namaKategori;
        }

        // Menampilkan ringkasan kategori
        public override string ToString()
        {
            return $"{IdKategori} - {NamaKategori}";
        }
    }

}
