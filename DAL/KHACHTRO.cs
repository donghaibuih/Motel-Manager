using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial  class KHACHTRO
    {
        public KHACHTRO(string maKhach, string tenKhach, string maPhong, DateTime ngaySinh, string gioiTinh, string soDienThoai, string diaChiThuongTru, string soCMND)
        {
            this.MAKHACH = maKhach;
            this.TENKHACH = tenKhach;
            this.MAPHONG = maPhong;
            this.NGAYSINH = ngaySinh;
            this.GIOITINH = gioiTinh;
            this.SODIENTHOAI = soDienThoai;
            this.DIACHITHUONGTRU = diaChiThuongTru;
            this.SOCMND = soCMND;
        }
    }
}
