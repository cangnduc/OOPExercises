abstract class SinhVien
{
    public int diem { get; set; }
    public abstract double HocBong();
}
class LopHocHB
{
    public List<SinhVien> dsSinhVien = new List<SinhVien>();
    public double TinhTongHocBong()
    {
        double tong = 0;
        foreach (SinhVien sv in dsSinhVien)
        {
            tong += sv.HocBong();
        }
        return tong;
    }
}
class SVTaiNang : SinhVien
{

    public SVTaiNang(int diem)
    {
        this.diem = diem;
    }
    public override double HocBong()
    {
        if (diem >= 9)
        {
            return 150000;
        }
        else if (diem >= 8)
        {
            return 100000;
        }

        return 0;
    }
}
class SVChinhQuy : SinhVien
{
    public SVChinhQuy(int diem)
    {
        this.diem = diem;
    }
    public override double HocBong()
    {
        if (diem >= 9)
        {
            return 200000;
        }
        else if (diem >= 8)
        {
            return 15000;
        }

        return 0;
    }
}