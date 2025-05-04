using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nama     : Irma Sena Marliyana
// NPM      : 230202084
// Kelas    : TI 2D
// Tugas    : Konversi Waktu

namespace TugasPraktikum1
{
    class KonversiWaktu
    {
        static void Main()
        {
            int totalDetik, jam, menit, detik;

            Console.Write("Masukkan jumlah detik: ");
            totalDetik = Convert.ToInt16(Console.ReadLine());

            jam = totalDetik / 3600;
            int sisa = totalDetik % 3600;
            menit = sisa / 60;
            detik = sisa % 60;

            Console.WriteLine("Hasil konversi: {0} jam, {1} menit, {2} detik", jam, menit, detik);
        }
    }
}