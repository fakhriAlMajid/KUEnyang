using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUEnyang_8
{
    public class Produk
    {
        // Properti sesuai dengan tabel Produk
        public string IdProduk { get; set; }
        public string NamaProduk { get; set; }
        public decimal HargaJual { get; set; }
        public decimal HargaBeli { get; set; }
        public int Stok { get; set; }
        public DateTime TanggalKadaluwarsa { get; set; }
        public string Status { get; set; } // Contoh: "Aktif", "Tidak Aktif", "Kadaluarsa"

        // Constructor default
        public Produk() { }

        // Constructor dengan parameter
        public Produk(string idProduk, string namaProduk, decimal hargaJual, decimal hargaBeli, int stok, DateTime tanggalKadaluwarsa, string status)
        {
            IdProduk = idProduk;
            NamaProduk = namaProduk;
            HargaJual = hargaJual;
            HargaBeli = hargaBeli;
            Stok = stok;
            TanggalKadaluwarsa = tanggalKadaluwarsa;
            Status = status;
        }

        // Method opsional: menampilkan ringkasan
        public override string ToString()
        {
            return $"{IdProduk} - {NamaProduk} | Rp{HargaJual:N0} | Stok: {Stok} | Exp: {TanggalKadaluwarsa:dd-MM-yyyy} | Status: {Status}";
        }
    }

}
