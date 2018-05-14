using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CHITIETPHONG:CONNECT
    {
        public bool capNhatChiTietPhong(CHITIETPHONG chiTietPhong)
        {
            try
            {
                var ketQua = from chiTietPhongTam in ketNoi.CHITIETPHONGs
                             where chiTietPhongTam.MAPHONG == chiTietPhong.MAPHONG
                             select chiTietPhongTam;
                foreach (var tam in ketQua)
                {
                    tam.GIOITINH = chiTietPhong.GIOITINH;
                    tam.DIACHITHUONGTRU = chiTietPhong.DIACHITHUONGTRU;
                    tam.NGAYSINH = chiTietPhong.NGAYSINH;
                    tam.SOCMND = chiTietPhong.SOCMND;
                    tam.SODIENTHOAI = chiTietPhong.SODIENTHOAI;
                    tam.TENKHACH = chiTietPhong.TENKHACH;


                }
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }


        }
        public List<CHITIETPHONG> layChiTietPhong()
        {
            var ketQua = (from chiTietPhong in ketNoi.CHITIETPHONGs
                          select chiTietPhong).ToList();
            return ketQua;
        }
        public bool themChiTietPhong(CHITIETPHONG chiTietPhong)
        {
            try
            {
                ketNoi.CHITIETPHONGs.InsertOnSubmit(chiTietPhong);
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        
        public bool xoaChiTietPhong(string maPhong)
        {
            try
            {
                var ketQua = from chiTietPhong in ketNoi.CHITIETPHONGs
                             where chiTietPhong.MAPHONG == maPhong
                             select chiTietPhong;
                foreach (CHITIETPHONG tam in ketQua)
                {
                    ketNoi.CHITIETPHONGs.DeleteOnSubmit(tam);
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
