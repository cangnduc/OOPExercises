abstract class HangHoa
{
    public int soluong { get; set; }
    public double Dongia { get; set; }

    public abstract double ThanhTien();
}
class HangBinhThuong : HangHoa
{

    public HangBinhThuong()
    {
        Console.WriteLine("Nhap so luong: ");
        soluong = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Nhap don gia: ");
        Dongia = double.Parse(Console.ReadLine() ?? "0");
    }
    public HangBinhThuong(double Dongia, int soluong)
    {

        this.Dongia = Dongia;
        this.soluong = soluong;
    }
    public override double ThanhTien()
    {
        return soluong * Dongia;
    }
}
class HangNhapKhau : HangHoa
{
    private double ThueNhapKhau { get; set; }
    public HangNhapKhau(double thue, double Dongia, int soluong)
    {
        this.ThueNhapKhau = thue;
        this.Dongia = Dongia;
        this.soluong = soluong;
    }
    public override double ThanhTien()
    {
        return soluong * Dongia * ThueNhapKhau;
    }
}
class HoaDon
{
    public List<HangHoa> dsHangHoa = new List<HangHoa>();
    public double TinhTongTien()
    {
        double tong = 0;
        foreach (var hh in dsHangHoa)
        {
            tong += hh.ThanhTien();
        }
        return tong;
    }
}