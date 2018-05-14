using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CHITIETHOADON:CONNECT
    {
        public bool capNhatChiTietHoaDon(CHITIETHOADON chiTietHoaDon)
        {
            try
            {
                var ketQua = from chiTietHoaDonTam in ketNoi.CHITIETHOADONs
                             where chiTietHoaDonTam.MAHOADON == chiTietHoaDon.MAHOADON
                             select chiTietHoaDonTam;
                foreach (var tam in ketQua)
                {
                    tam.SOCU = chiTietHoaDon.SOCU;
                    tam.SOLUONG = chiTietHoaDon.SOLUONG;
                    tam.THANHTIEN = chiTietHoaDon.THANHTIEN;
               
                    

                }
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }


        }

        public List<CHITIETHOADON> layChiTietHoaDonTheoMaHoaDon(string maHoaDon)
        {
            var ketQua = (from chiTietHoaDon in ketNoi.CHITIETHOADONs
                         where chiTietHoaDon.MAHOADON == maHoaDon
                         select chiTietHoaDon).ToList();
            return ketQua;
        }
        public List<CHITIETHOADON> layChiTietHoaDon()
        {
            var ketQua = (from chiTietHoaDon in ketNoi.CHITIETHOADONs
                          select chiTietHoaDon).ToList();
            return ketQua;
        }
        public bool themChiTietHoaDon(CHITIETHOADON chiTietHoaDon)
        {
            try
            {
                ketNoi.CHITIETHOADONs.InsertOnSubmit(chiTietHoaDon);
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
        public bool xoaChiTietHoaDon(string maHoaDon)
        {
            try
            {
                var ketQua = from chiTietHoaDon in ketNoi.CHITIETHOADONs
                             where chiTietHoaDon.MAHOADON == maHoaDon
                             select chiTietHoaDon;
                foreach (CHITIETHOADON chiTietHoaDonTam in ketQua)
                {
                    ketNoi.CHITIETHOADONs.DeleteOnSubmit(chiTietHoaDonTam);
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
