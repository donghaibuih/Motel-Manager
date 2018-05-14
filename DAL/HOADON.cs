using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public partial  class HOADON
    {
       public HOADON(string maHoaDon, string maKhach, string maNhanVien, string maPhong, DateTime ngayLap, double tongTien)
       {
           this.MAHOADON = maHoaDon;
           this.MAKHACH = maKhach;
           this.MANHANVIEN = maNhanVien;
           this.MAPHONG = maPhong;
           this.NGAYLAP = ngayLap;
           this.TONGTIEN = tongTien;
       }
    }
}
