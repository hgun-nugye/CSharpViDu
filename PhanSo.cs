using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    public static class Library
    {
        public static int GCD(int a, int b)

        {
            while (b != 0)
            {
                int temp = b; b = a % b; a = temp;
            }
            return a;
        }
    }
    public class PhanSo
    {
        private int _tuSo, _mauSo;

        //khai bao properties
        public int TuSo
        {
            get { return _tuSo; }
            set { _tuSo = value; }
        }
        public int MauSo
        {
            get { return _mauSo; }
            set { _mauSo = value; }
        }

        //khoi tao phan so 
        public PhanSo(int ts = 0, int ms = 1)
        {
            _tuSo = ts;
            if (_mauSo != 0) _mauSo = ms;
        }

        //thiet lap sao chep phan so
        public PhanSo(PhanSo p)
        {
            p.TuSo = TuSo;
            p.MauSo = MauSo;
        }
        //ham nhap phan so
        public void Nhap()
        {
            Console.Write("Nhap vao tu so: ");
            _tuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap vao mau so: ");
                _mauSo = int.Parse(Console.ReadLine());
            }
            while (_mauSo == 0);
        }
        //ham xuat phan so
        public void Xuat()
        {
            Console.WriteLine(_tuSo + "/" + _mauSo);
        }
        //ham toi gian phan so
        public void PSToiGian()
        {
            int gcd = Library.GCD(_tuSo, _mauSo);
            _tuSo /= gcd;
            _mauSo /= gcd;
        }
    }
    public class ListPhanSo
    {
        private List<PhanSo> _dsPS = new List<PhanSo>();
        private int size;
        public void NhapDSPS()
        {
            do
            {
                Console.WriteLine("Nhap vao size list: ");
                size = int.Parse(Console.ReadLine());
            } while (size < 1);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Nhap vao phan tu thu {0}: ", i+1);
                PhanSo ps = new PhanSo();
                ps.Nhap();
                _dsPS.Add(ps);
            }
        }
        public void InDSPS()
        {
            foreach (PhanSo ps in _dsPS)
            {
                ps.Xuat();
            }
        }
        public PhanSo MaxPS()
        {
            PhanSo max = _dsPS[0];
            foreach (PhanSo ps in _dsPS)
            {
                if ((double)ps.TuSo / ps.MauSo > (double)max.TuSo / max.MauSo)
                    max = ps;
            }
            return max;
        }
        public void SapXepPS()
        {
            _dsPS.Sort((ps1, ps2) => ((double)ps1.TuSo / ps1.MauSo).CompareTo((double)ps2.TuSo / ps2.MauSo));
        }
        static void Main(string[] args)
        {
            ListPhanSo dsps = new ListPhanSo();
            dsps.NhapDSPS();

            Console.WriteLine("Day la danh sach phan so vua nhap: ");
            dsps.InDSPS();

            Console.WriteLine("Day la phan so lon nhat cua danh sach: ");
            PhanSo max=dsps.MaxPS();
            Console.WriteLine(max.TuSo + "/" + max.MauSo);

            dsps.SapXepPS();
            Console.WriteLine("Day la danh sach phan so da duoc sap xep: ");
            dsps.InDSPS();
        }
    }
}
