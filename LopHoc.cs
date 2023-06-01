interface IHocSinh
{
    public double Giatien();
}
class LopHoc
{

    public List<IHocSinh> dsHocSinh { get; set; } = new List<IHocSinh>();
    public double TinhGia()
    {
        double gia = 0;
        foreach (var hs in dsHocSinh)
        {
            gia += hs.Giatien();
        }
        return gia;
    }
}
class HocSinh
{
    public double giaDongPhuc { get; set; }
}
class HocSinhNam : HocSinh, IHocSinh
{


    public double Giatien()
    {
        return 100;
    }
}

class HocSinhNu : HocSinh, IHocSinh
{
    public double Giatien()
    {
        return 120;
    }
}