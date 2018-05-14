using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class NHANVIEN
    {
        public NHANVIEN(string maNhanVien, string tenNhanVien, string diaChi, string soDienThoai, string chucVu)
        {
            this.MANHANVIEN = maNhanVien;
            this.TENNHANVIEN = tenNhanVien;
            this.DIACHI = diaChi;
            this.SODIENTHOAI = soDienThoai;
            this.CHUCVU = chucVu;     
        }
    }
}
