class Toado
{
    public int x, y;
    public void Nhap(string ghichu)
    {
        Console.WriteLine("Nhap toa do " + ghichu);
        Console.WriteLine("Nhap x: ");
        x = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Nhap y: ");
        y = int.Parse(Console.ReadLine() ?? "0");
    }
    public double khoangCach(Toado b)
    {
        return Math.Sqrt(Math.Pow(x - b.x, 2) + Math.Pow(y - b.y, 2));
    }
}
class TamGiac
{
    Toado A;
    Toado B;
    Toado C;
    public TamGiac()
    {
        A = new Toado();
        A.Nhap("A");
        B = new Toado();
        B.Nhap("B");
        C = new Toado();
        C.Nhap("C");
    }
    public bool KiemTra()
    {

        return A.khoangCach(B) + A.khoangCach(C) > B.khoangCach(C);

    }
}
class Dagiac1
{
    List<Toado> dsToado;
    int soDinh;
    public Dagiac1()
    {
        dsToado = new List<Toado>();
        Console.WriteLine("Nhap so dinh: ");
        soDinh = int.Parse(Console.ReadLine() ?? "0");
        while (soDinh < 3)
        {
            if (soDinh == 0)
            {
                Console.WriteLine("Nhap so dinh > 0: ");
                soDinh = int.Parse(Console.ReadLine() ?? "0");
            }
            else if (soDinh == 1)
            {
                Console.WriteLine("Nhap so dinh > 1: ");
                soDinh = int.Parse(Console.ReadLine() ?? "0");
            }
            else if (soDinh == 2)
            {
                Console.WriteLine("Nhap so dinh > 2: ");
                soDinh = int.Parse(Console.ReadLine() ?? "0");
            }

        }

        for (int i = 0; i < soDinh; i++)
        {
            Toado toado = new Toado();
            toado.Nhap("Dinh " + i);
            dsToado.Add(toado);
        }
    }
    public double TinhChuVi()
    {
        double chuVi = 0;
        for (int i = 0; i < soDinh - 1; i++)
        {
            chuVi += dsToado[i].khoangCach(dsToado[i + 1]);
        }
        chuVi += dsToado[soDinh - 1].khoangCach(dsToado[0]);
        return chuVi;
    }
}