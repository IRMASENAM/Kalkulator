using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nama     : Irma Sena Marliyana
// NPM      : 230202084
// Kelas    : TI 2D
// Tugas    : Konversi Suhu

namespace TugasPraktikum1
{
    class KonversiSuhu
    {
        static void Main()
        {
            Console.Write("Masukkan suhu dalam Celcius: ");
            string input = Console.ReadLine();

            short celcius = Convert.ToInt16(input);

            double fahrenheit = (celcius * 9 / 5) + 32;
            double reamur = celcius * 4 / 5;
            double kelvin = celcius + 273.15;

            Console.WriteLine($"{celcius}°C = {fahrenheit}°F");
            Console.WriteLine($"{celcius}°C = {reamur}°R");
            Console.WriteLine($"{celcius}°C = {kelvin} K");
        }
    }
}
