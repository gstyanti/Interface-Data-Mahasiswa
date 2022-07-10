using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolimorphism2
{
    public class ConvertToCsv : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            //konversi objek mahasiswa ke csv
            string csv = string.Format("{0},{1},{2}", mhs.nim, mhs.nama, mhs.email);

            Console.WriteLine("Hasil Konversi ke csv:\n");
            Console.WriteLine(csv);
        }
    }
}
