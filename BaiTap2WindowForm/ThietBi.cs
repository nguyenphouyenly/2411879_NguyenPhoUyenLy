using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2WindowForm
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        public ThietBi(string ma, string ten, string nuoc, double gia, int sl)
        {
            MaThietBi = ma;
            TenThietBi = ten;
            NuocSanXuat = nuoc;
            DonGia = gia;
            SoLuong = sl;
        }

        public double ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public void HienThi()
        {
            MessageBox.Show(
                "Mã thiết bị: " + MaThietBi +
                "\nTên thiết bị: " + TenThietBi +
                "\nNước sản xuất: " + NuocSanXuat +
                "\nĐơn giá: " + DonGia +
                "\nSố lượng: " + SoLuong +
                "\nThành tiền: " + ThanhTien()
            );
        }
    }
}
