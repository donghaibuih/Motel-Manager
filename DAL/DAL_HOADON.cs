using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HOADON : CONNECT
    {
        public bool capNhatHoaDon(HOADON hoaDon)
        {
            try
            {
                var ketQua = from hoaDonTam in ketNoi.HOADONs
                             where hoaDonTam.MAHOADON == hoaDon.MAHOADON
                             select hoaDonTam;
                foreach (var tam in ketQua)
                {

                    tam.TONGTIEN = hoaDon.TONGTIEN;
                    tam.NGAYLAP = hoaDon.NGAYLAP;
                }
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }


        }

        public int dem()
        {
            try
            {
                return ketNoi.HOADONs.Count();
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public List<HOADON> layHoaDon()
        {
            try
            {
                var ketQua = (from hoaDon in ketNoi.HOADONs
                              select hoaDon).ToList();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool themHoaDon(HOADON hoaDon)
        {
            try
            {
                ketNoi.HOADONs.InsertOnSubmit(hoaDon);
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public HOADON layHoaDonTheoMaKhach(string maKhach)
        {
            try
            {
                var ketQua = (from hoaDon in ketNoi.HOADONs
                              where hoaDon.MAKHACH == maKhach
                              select hoaDon).FirstOrDefault();
                return ketQua;

            }
            catch (Exception)
            {

                return null;
            }

        }

        public List<HOADON> layHoaDonTheoPhong(string maPhong)
        {
            try
            {
                var ketQua = (from hoaDonTam in ketNoi.HOADONs
                              where hoaDonTam.MAHOADON == maPhong
                              select hoaDonTam).ToList();
                return ketQua;
            }
            catch (Exception)
            {
                return null;
            }
        }

       
        public bool xoaHoaDon(string maHoaDon)
        {
            try
            {
                var ketQua = from hoaDon in ketNoi.HOADONs
                             where hoaDon.MAHOADON == maHoaDon
                             select hoaDon;
                foreach (HOADON hoaDonTam in ketQua)
                {
                    ketNoi.HOADONs.DeleteOnSubmit(hoaDonTam);
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
