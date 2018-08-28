using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    class Program
    {
        static void Main(string[] args)
        {
            int pil;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Insert Mahasiswa");
            Console.WriteLine("2. Insert Dosen");
            Console.WriteLine("3. Insert Mata Kuliah");
            Console.WriteLine("4. Insert Ruang Kuliah");
            Console.WriteLine("5. Read Mahasiswa");
            Console.WriteLine("6. Read Dosen");
            Console.WriteLine("7. Read Mata Kuliah");
            Console.WriteLine("8. Read Ruang Kuliah");
            Console.WriteLine("9. Update Mahasiswa");
            Console.WriteLine("10. Delete MataKuliah");
            Console.WriteLine("11. Exit");
            Console.WriteLine("-------------------------------");
            Console.Write("Pilih Menu : "); pil = Convert.ToInt32(Console.ReadLine());

            switch (pil)
            {
                case 1:
                    MahasiswaController panggilmhs = new MahasiswaController();
                    panggilmhs.Insert();
                    break;
                case 2:
                    MahasiswaController panggildosen = new MahasiswaController();
                    panggildosen.Insertdosen();
                    break;
                case 3:
                    MahasiswaController panggilmk = new MahasiswaController();
                    panggilmk.Insertmatakuliah();
                    break;
                case 4:
                    MahasiswaController panggilrk = new MahasiswaController();
                    panggilrk.Insertruangkuliah();
                    break;
                case 5:
                    MahasiswaController panggilrmhs = new MahasiswaController();
                    panggilrmhs.Getmahasiswa();
                    break;
                case 6:
                    MahasiswaController panggilrdosen = new MahasiswaController();
                    panggilrdosen.Getdosen();
                    break;
                case 7:
                    MahasiswaController panggilrmk = new MahasiswaController();
                    panggilrmk.Getmatakuliah();
                    break;
                case 8:
                    MahasiswaController panggilrrk = new MahasiswaController();
                    panggilrrk.Getruangkuliah();
                    break;
                case 9:
                    MahasiswaController panggilumhs = new MahasiswaController();
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    int input1;
                    input1 = Convert.ToInt16(System.Console.ReadLine());
                    panggilumhs.Updatemahasiswa(input1);
                    break;
                case 10:
                    MahasiswaController panggildmk = new MahasiswaController();
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    string input;
                    input = Convert.ToString(System.Console.ReadLine());
                    panggildmk.deletematakuliah(input);
                    break;
                case 11:
                    break;
                default:
                    break;
            }
        }
    }
    public class MahasiswaController
    {
        akademikEntities _context = new akademikEntities();

        public void Insertdosen()

        {
            Console.Clear();
            System.Console.Write("Masukkan ID Dosen : ");
            string ID_Dosen = Console.ReadLine();
            System.Console.Write("Nama Dosen : ");
            string Nama_Dosen = System.Console.ReadLine();
            System.Console.Write("Jenis Kelamin : ");
            string jenis_kelamin = System.Console.ReadLine();
            System.Console.Write("Alamat Dosen : ");
            string alamat_dosen = System.Console.ReadLine();
            System.Console.Write("Email : ");
            string Email_dosen = System.Console.ReadLine();
            System.Console.Write("Telepon : ");
            string Telepon = System.Console.ReadLine();


            dosen call = new dosen();
            {
                call.id = ID_Dosen;
                call.nama = Nama_Dosen;
                call.jenis_kelamin = jenis_kelamin;
                call.alamat = alamat_dosen;
                call.email = Email_dosen;
                call.telepon = Telepon;

            };
            try
            {
                _context.dosen.Add(call);
                var result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }

        public void Insert()
        {
            Console.Clear();
            System.Console.Write("Masukkan ID Mahasiswa : ");
            string ID_Mahasiswa = Console.ReadLine();
            System.Console.Write("Nama Mahasiswa : ");
            string Nama_Mahasiswa = System.Console.ReadLine();
            System.Console.Write("Jenis Kelamin : ");
            string jenis_kelamin = System.Console.ReadLine();
            System.Console.Write("Alamat : ");
            string alamat_mahasiswa = System.Console.ReadLine();
            System.Console.Write("Email : ");
            string Email = System.Console.ReadLine();
            System.Console.Write("Telepon : ");
            string Telepon = System.Console.ReadLine();
            System.Console.Write("ID Prodi : ");
            string Id_Prodi = System.Console.ReadLine();
            System.Console.Write("ID Dosen : ");
            string Id_dosen = System.Console.ReadLine();
            System.Console.Write("Jurusan : ");
            string prodi = System.Console.ReadLine();

            mahasiswa call = new mahasiswa();
            {
                call.id = ID_Mahasiswa;
                call.nama = Nama_Mahasiswa;
                call.jenis_kelamin = jenis_kelamin;
                call.alamat = alamat_mahasiswa;
                call.email = Email;
                call.telepon = Telepon;
                call.id_prodi = Id_Prodi;
                call.id_dosen = Id_dosen;
                call.prodi = prodi;

            };
            try
            {
                _context.mahasiswa.Add(call);
                var result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        public void Insertmatakuliah()
        {
            Console.Clear();
            System.Console.Write("Masukkan ID Mata Kuliah : ");
            string ID_matakuliah = Console.ReadLine();
            System.Console.Write("Nama Mata Kuliah : ");
            string Nama_Matakuliah = System.Console.ReadLine();
            decimal sks = System.Convert.ToDecimal(Console.ReadLine());
            System.Console.Write("SKS : ");
            string id_Ruangkuliah = System.Console.ReadLine();
            System.Console.Write("ID Ruang Kuliah : ");


            matakuliah call = new matakuliah();
            {
                call.id = ID_matakuliah;
                call.nama = Nama_Matakuliah;
                call.sks = sks;
                call.id_ruangkuliah = id_Ruangkuliah;

            };
            try
            {
                _context.matakuliah.Add(call);
                var result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        public void Insertruangkuliah()
        {
            Console.Clear();
            System.Console.Write("Masukkan ID Ruang Kuliah : ");
            string ID_ruang = Console.ReadLine();
            System.Console.Write("Nama Ruang : ");
            string Nama_ruang = System.Console.ReadLine();
            decimal Kuota = System.Convert.ToDecimal(Console.ReadLine());
            System.Console.Write("Kuota : ");


            ruang_kuliah call = new ruang_kuliah();
            {
                call.id = ID_ruang;
                call.nama = Nama_ruang;
                call.kuota = Kuota;

            };
            try
            {
                _context.ruang_kuliah.Add(call);
                var result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }

        public List<mahasiswa> Getmahasiswa()
        {
            var getalls = _context.mahasiswa.ToList();
            foreach (mahasiswa mahasiswa in getalls)
            {
                System.Console.WriteLine("ID MAHASISWA      : " + mahasiswa.id);
                System.Console.WriteLine("NAMA              : " + mahasiswa.nama);
                System.Console.WriteLine("ALAMAT            : " + mahasiswa.alamat);
                System.Console.WriteLine("EMAIL             : " + mahasiswa.email);
                System.Console.WriteLine("TELEPON           : " + mahasiswa.telepon);
                System.Console.WriteLine("----------------------------------------------");
            }
            Console.ReadKey(true);
            return getalls;
        }
        public List<dosen> Getdosen()
        {
            var getalls = _context.dosen.ToList();
            foreach (dosen dosen in getalls)
            {
                System.Console.WriteLine("ID Dosen          : " + dosen.id);
                System.Console.WriteLine("NAMA              : " + dosen.nama);
                System.Console.WriteLine("ALAMAT            : " + dosen.alamat);
                System.Console.WriteLine("EMAIL             : " + dosen.email);
                System.Console.WriteLine("TELEPON           : " + dosen.telepon);
                System.Console.WriteLine("----------------------------------------------");
            }
            Console.ReadKey(true);
            return getalls;
        }
        public List<matakuliah> Getmatakuliah()
        {
            var getalls = _context.matakuliah.ToList();
            foreach (matakuliah matakuliah in getalls)
            {
                System.Console.WriteLine("ID MATA KULIAH          : " + matakuliah.id);
                System.Console.WriteLine("NAMA MATA KULIAH        : " + matakuliah.nama);
                System.Console.WriteLine("SKS                     : " + matakuliah.sks);
                System.Console.WriteLine("ID RUANG KULIAH         : " + matakuliah.id_ruangkuliah);
                System.Console.WriteLine("----------------------------------------------");
            }
            Console.ReadKey(true);
            return getalls;
        }
        public List<ruang_kuliah> Getruangkuliah()
        {
            var getalls = _context.ruang_kuliah.ToList();
            foreach (ruang_kuliah ruang_kuliah in getalls)
            {
                System.Console.WriteLine("ID RUANG KULIAH          : " + ruang_kuliah.id);
                System.Console.WriteLine("NAMA RUANG KULIAH        : " + ruang_kuliah.nama);
                System.Console.WriteLine("KUOTA                    : " + ruang_kuliah.kuota);
                System.Console.WriteLine("----------------------------------------------");
            }
            Console.ReadKey(true);
            return getalls;
        }
        public mahasiswa GetById(int input)
        {
            var mahasiswa = _context.mahasiswa.Find(input);
            if (mahasiswa == null)
            {
                System.Console.WriteLine("Id tersebut tidak ada");
            }
            return mahasiswa;
        }
        public int Updatemahasiswa(int input)
        {
            System.Console.Write("MASUKKAN NAMA BARU MAHASISWA     : ");
            string Nama = System.Console.ReadLine();
            System.Console.Write("MASUKKAN ALAMAT BARU MAHASISWA : ");
            string alamat = System.Console.ReadLine();
            System.Console.Write("MASUKKAN ID      : ");
            string id_mhs = System.Console.ReadLine();

            var getmhs = _context.mahasiswa.Find(Convert.ToInt16(id_mhs));
            if (getmhs == null)
            {
                System.Console.Write("TIDAK ADA ID MAHASISWA : " + id_mhs);
            }
            else
            {
                mahasiswa mahasiswa = GetById(input);
                mahasiswa.nama = Nama;
                mahasiswa.alamat = alamat;
                _context.Entry(mahasiswa).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
            }
            return input;
        }
        public void deletematakuliah (string input)
        {
            var x = (from y in _context.matakuliah where y.id == input select y).FirstOrDefault();
            _context.matakuliah.Remove(x);
            _context.SaveChanges();
        }
    }
}







