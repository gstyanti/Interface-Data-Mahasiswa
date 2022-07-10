using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolimorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            //contoh data mahasiswa
            Mahasiswa mhs = new Mahasiswa();
            mhs.nim = "21.11.4326";
            mhs.nama = "Gusti Ayu Putu Febriyanti";
            mhs.email = "gustiayu@students.amikom.ac.id";

            Console.WriteLine("Pilih Format Konversi Data[1..3]: ");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. Csv\n");

            Console.Write("Nomor Format Data [1..3]: ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert; // mendeklarasikan objek konversi

            if (nomorFormatData == 1)
                convert = new ConvertToJson();
            else if (nomorFormatData == 2)
                convert = new ConvertToXml();
            else 
                convert = new ConvertToCsv();

            // konversi objek mhs berdasarkan format yang dipilih
            convert.Convert(mhs);

            Console.ReadKey();
        }
    }
}
