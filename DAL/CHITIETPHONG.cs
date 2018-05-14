using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class CHITIETPHONG
    {
        public CHITIETPHONG(string maPhong, string maKhach, string tenKhach, DateTime ngaySinh, string gioiTinh, string soDienTHoai, string diaChiThuongTru, string soCMND)
        {
            this.MAKHACH = maKhach;
            this.MAPHONG = MAPHONG;
            this.TENKHACH = tenKhach;
            this.NGAYSINH = ngaySinh;
            this.GIOITINH = gioiTinh;
            this.SOCMND = soCMND;
            this.SODIENTHOAI = soDienTHoai;
            this.DIACHITHUONGTRU = diaChiThuongTru;
        }
    }
}
