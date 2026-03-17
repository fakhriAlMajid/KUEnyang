using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUEnyang_8
{
    public class Karyawan
    {
        // Properties sesuai dengan kolom di tabel
        public string IdKaryawan { get; set; }
        public string NamaKaryawan { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Alamat { get; set; }
        public string NoTelepon { get; set; }

        // Constructor default
        public Karyawan() { }

        // Constructor dengan parameter
        public Karyawan(string idKaryawan, string namaKaryawan, string username, string password, string alamat, string noTelepon)
        {
            IdKaryawan = idKaryawan;
            NamaKaryawan = namaKaryawan;
            Username = username;
            Password = password;
            Alamat = alamat;
            NoTelepon = noTelepon;
        }

        // Method opsional, misalnya menampilkan data karyawan
        public override string ToString()
        {
            return $"{IdKaryawan} - {NamaKaryawan}, {Username}, {NoTelepon}";
        }
    }

}
