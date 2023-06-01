
namespace ThiOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            HoaDonBanHang();
            //HocBongSV();
            //TamGiac();
        }

        void Sachs()
        {
            Sach sach = new Sach();
            sach.Nhap();
            Console.WriteLine("Do day sach: " + sach.TinhDoDay());
            Console.ReadKey();
        }
        public static void LopHoc1()
        {
            LopHoc lophoc = new LopHoc();
            lophoc.dsHocSinh.Add(new HocSinhNam());
            lophoc.dsHocSinh.Add(new HocSinhNu());
            Console.WriteLine(lophoc.TinhGia());

        }
        public static void TamGiac()
        {
            TamGiac tamGiac = new TamGiac();
            Console.WriteLine(tamGiac.KiemTra());
        }
        public static void HocBongSV()
        {
            LopHocHB lopHocHB = new LopHocHB();
            lopHocHB.dsSinhVien.Add(new SVTaiNang(8));
            lopHocHB.dsSinhVien.Add(new SVChinhQuy(8));
            Console.WriteLine(lopHocHB.TinhTongHocBong());
        }

        public static void TinhChuVi()
        {
            Dagiac1 dagiac = new Dagiac1();
            Console.WriteLine(dagiac.TinhChuVi());
        }
        public static void HoaDonBanHang()
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.dsHangHoa.Add(new HangBinhThuong(100, 2));
            hoaDon.dsHangHoa.Add(new HangNhapKhau(0.5, 100, 2));
            Console.WriteLine(hoaDon.TinhTongTien());
        }
    }

}
