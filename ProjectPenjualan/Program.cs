using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Penjualan ");
            Console.WriteLine("2. Hapus Penjualan ");
            Console.WriteLine("3. Tampilkan Penjualan ");
            Console.WriteLine("4. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Penjualan penjualan = new Penjualan();
            Console.WriteLine("Tambah Penjualan \n");
            Console.Write("Nota Penjualan : ");
            penjualan.Nota = Console.ReadLine();
           
            Console.Write("Tanggal Penjualan : ");
            penjualan.Tanggal = Console.ReadLine();
            
            Console.Write("Customer  : ");
            penjualan.Customer = Console.ReadLine();

            Console.Write("Jenis Pembayaran (T/K):");
            penjualan.Jenis = Console.ReadLine();

            Console.Write("Total Pembayaran  : ");
            penjualan.Total = double.Parse(Console.ReadLine());
            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            int nomor = -1, hapus = -1;
            Console.WriteLine();
            Console.WriteLine("Hapus Data Produk\n");
            Console.Write("Kode Produk : ");
            string kodeP = Console.ReadLine();
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                nomor++;
                if (penjualan.Nota == kodeP)
                {
                    hapus = nomor;
                }
            }
            if (hapus != -1)
            {
                daftarPenjualan.RemoveAt(hapus);
                Console.Write("\nData Produk dengan Kode Produk : ");
                Console.Write(kodeP);
                Console.WriteLine(" Berhasil Dihapus ");
            }
            else
            {
                Console.WriteLine("\nKode Produk Tidak Ditemukan ");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int urutan = 0;
            Console.WriteLine("Data Penjualan\n");
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                urutan++;
                Console.Write("{0}. {1}, {2}, {3}, ", urutan, penjualan.Nota, penjualan.Tanggal, penjualan.Customer); 
                    if (penjualan.Jenis == "T")
                {
                    Console.Write("Tunai");
                }
                else
                {
                    Console.Write("Kredit");
                }
                Console.WriteLine(", {0}", penjualan.Total);
            }
            if (urutan < 1)
            {
                Console.WriteLine("\nData Produk Kosong \n");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
