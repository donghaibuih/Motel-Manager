using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NHANVIEN:CONNECT
    {
        public bool capNhatNhanVien(NHANVIEN nhanVien)
        {
            try
            {
                var ketQua = from nhanVienTam in ketNoi.NHANVIENs
                             where nhanVienTam.MANHANVIEN == nhanVien.MANHANVIEN
                             select nhanVienTam;
                foreach (var tam in ketQua)
                {
                    tam.DIACHI = nhanVien.DIACHI;
                    tam.CHUCVU = nhanVien.CHUCVU;
                    tam.SODIENTHOAI = nhanVien.SODIENTHOAI;
                    tam.TENNHANVIEN = nhanVien.TENNHANVIEN;    
                }
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }


        }
        public List<NHANVIEN> layNhanVien()
        {
            var ketQua = (from nhanVien in ketNoi.NHANVIENs
                          select nhanVien).ToList();
            return ketQua;
        }

        public NHANVIEN layNhanVienTheoMaNhanVien(string maNhanVien)
        {
            try
            {
                var ketQua = (from nhanVien in ketNoi.NHANVIENs
                              where nhanVien.MANHANVIEN == maNhanVien
                              select nhanVien).FirstOrDefault();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool themNhanVien(NHANVIEN nhanVien)
        {
            try
            {
                ketNoi.NHANVIENs.InsertOnSubmit(nhanVien);
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
        public bool xoaNhanVien(string maNhanVien)
        {
            try
            {
                var ketQua = from nhanVien in ketNoi.NHANVIENs
                             where nhanVien.MANHANVIEN == maNhanVien
                             select nhanVien;
                foreach (NHANVIEN nhanVienTam in ketQua)
                {
                    ketNoi.NHANVIENs.DeleteOnSubmit(nhanVienTam);
                }
                ketNoi.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }
    
    }
}
