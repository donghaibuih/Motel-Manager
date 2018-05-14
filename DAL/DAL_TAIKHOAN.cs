using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TAIKHOAN : CONNECT
    {

        public bool capTaiKhoan(TAIKHOAN taiKhoan)
        {
            try
            {
                var ketQua = from taiKhoanTam in ketNoi.TAIKHOANs
                             where taiKhoanTam.TENTAIKHOAN == taiKhoan.TENTAIKHOAN
                             select taiKhoanTam;
                foreach (var tam in ketQua)
                {
                    tam.MATKHAU = taiKhoan.MATKHAU;


                }
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }


        }
        public TAIKHOAN layTaiKhoanTheoTenTaiKhoan(string tenTaiKhoan)
        {
            try
            {
                var ketQua = (from taiKhoan in ketNoi.TAIKHOANs
                              where taiKhoan.TENTAIKHOAN == tenTaiKhoan
                              select taiKhoan).FirstOrDefault();
                return ketQua;

            }
            catch (Exception)
            {
                return null;

            }
        }
        public bool themTaiKhoan(TAIKHOAN taiKhoan)
        {
            try
            {
                ketNoi.TAIKHOANs.InsertOnSubmit(taiKhoan);
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool xoaTaiKhoan(string tenTaiKhoan)
        {
            try
            {
                var ketQua = from taiKhoan in ketNoi.TAIKHOANs
                             where taiKhoan.TENTAIKHOAN == tenTaiKhoan
                             select taiKhoan;
                foreach (TAIKHOAN taiKhoan2 in ketQua)
                {
                    ketNoi.TAIKHOANs.DeleteOnSubmit(taiKhoan2);
                }
                ketNoi.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }
        public bool dangNhap(string tenDangNhap, string matKhau)
        {
            try
            {
                var ketQua = from dangNhap in ketNoi.TAIKHOANs
                             where dangNhap.TENTAIKHOAN == tenDangNhap && dangNhap.MATKHAU == matKhau
                             select dangNhap;
                if (ketQua.Any())
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
