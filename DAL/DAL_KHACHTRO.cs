using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KHACHTRO : CONNECT
    {


        public bool capNhatKhachTro(KHACHTRO khach)
        {
            try
            {
                var ketQua = from khachTro in ketNoi.KHACHTROs
                             where khachTro.MAKHACH == khach.MAKHACH
                             select khachTro;
                foreach (var tam in ketQua)
                {
                    tam.GIOITINH = khach.GIOITINH;
                    tam.DIACHITHUONGTRU = khach.DIACHITHUONGTRU;
                    tam.NGAYSINH = khach.NGAYSINH;
                    tam.SOCMND = tam.SOCMND;
                    tam.TENKHACH = khach.TENKHACH;
                    tam.SODIENTHOAI = tam.SODIENTHOAI;

                }
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }


        }

        public List<KHACHTRO> layKhach()
        {
            var ketQua = (from khach in ketNoi.KHACHTROs
                          select khach).ToList();
            return ketQua;
        }
        public bool themKhach(KHACHTRO khach)
        {
            try
            {
                ketNoi.KHACHTROs.InsertOnSubmit(khach);
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }

        }

        public KHACHTRO layKhachTheoMaPhong(string maPhong)
        {
            try
            {
                var ketQua = (from khachTro in ketNoi.KHACHTROs
                              where khachTro.MAPHONG == maPhong
                              select khachTro).FirstOrDefault();
                return ketQua;
            }
            catch (Exception)
            {

                return null;
            }

        }
        public bool xoaKhach(string maKhach)
        {
            try
            {
                var ketQua = from khach in ketNoi.KHACHTROs
                             where khach.MAKHACH == maKhach
                             select khach;
                foreach (KHACHTRO phong2 in ketQua)
                {
                    ketNoi.KHACHTROs.DeleteOnSubmit(phong2);
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
