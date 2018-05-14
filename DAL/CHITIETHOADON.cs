using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class CHITIETHOADON
    {
        public CHITIETHOADON( string maHoaDon, string tenDichVu, int soCu, int soLuong, float thanhTien)
        {
          
            this.MAHOADON = maHoaDon;
            this.TENDICHVU = tenDichVu;
            this.SOCU = soCu;
            this.SOLUONG = soLuong;
            this.THANHTIEN = thanhTien;
        }
    }
}
