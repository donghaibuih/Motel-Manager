using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_TAIKHOAN
    {
        DAL_TAIKHOAN dal_taiKhoan = new DAL_TAIKHOAN();
        public bool dangNhap(string tenDangNhap, string matKhau)
        {
            return dal_taiKhoan.dangNhap(tenDangNhap, matKhau);
        }
        public TAIKHOAN layTaiKhoanTheoTenTaiKhoan(string tenTaiKhoan)
        {
            return dal_taiKhoan.layTaiKhoanTheoTenTaiKhoan(tenTaiKhoan);
        }
    }
}
