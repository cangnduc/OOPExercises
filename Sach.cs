public class Sach
{
    string maSach;
    public string tenSach { get; private set; }
    int soTrang;

    public Sach()
    {
        maSach = "";
        tenSach = "";
        soTrang = 0;
    }
    public Sach(string maSach, string tenSach, int soTrang)
    {
        this.maSach = maSach;
        this.tenSach = tenSach;
        this.soTrang = soTrang;
    }
    public void Nhap()
    {
        Console.WriteLine("Nhap ma sach: ");



        maSach = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Nhap ten sach: ");
        tenSach = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Nhap so trang: ");
        soTrang = int.Parse(Console.ReadLine() ?? "0");
    }

    public double TinhDoDay()
    {
        return soTrang * 0.1;
    }
}