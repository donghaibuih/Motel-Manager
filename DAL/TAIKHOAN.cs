using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class TAIKHOAN
    {
        public TAIKHOAN(string maNhanVien, string tenTaiKhoan, string matKhau)
        {
            this.MANHANVIEN = maNhanVien;
            this.TENTAIKHOAN = tenTaiKhoan;
            this.MATKHAU = matKhau;
        }
    }
}
