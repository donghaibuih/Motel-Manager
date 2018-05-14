using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{


    public class DAL_PHONGTRO : CONNECT
    {

        public PHONGTRO layDoiTuongPhongTheoMaPhong(string maPhong)
        {
            try
            {
                var ketQua = (from phong in ketNoi.PHONGTROs
                              where phong.MAPHONG == maPhong
                              select phong).FirstOrDefault();
                return ketQua;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool capNhatPhong(PHONGTRO phong)
        {
            try
            {
                var ketQua = from phongTro in ketNoi.PHONGTROs
                             where phongTro.MAPHONG == phong.MAPHONG
                             select phongTro;
                foreach (var tam in ketQua)
                {
                    tam.TRANGTHAI = phong.TRANGTHAI;
                    tam.TIENPHONG = phong.TIENPHONG;
                    tam.SONGUOIO = phong.SONGUOIO;

                }
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }


        }

        public bool capNhatSoNguoiTrongPhong(string maPhong,int soNguoi)
        {
            try
            {
                var ketQua = from phongTro in ketNoi.PHONGTROs
                             where phongTro.MAPHONG == maPhong
                             select phongTro;
                foreach (var tam in ketQua)
                {
                    tam.SONGUOIO = soNguoi;

                }
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }


        }


        public List<PHONGTRO> layPhong()
        {
            var ketQua = (from phong in ketNoi.PHONGTROs
                          select phong).ToList();
            return ketQua;
        }
        public List<PHONGTRO> layPhongTangDauTien(int batDau, int ketThuc)
        {
            var ketQua = (from phong in ketNoi.PHONGTROs
                          select phong).Take(ketThuc - batDau + 1).ToList();
            return ketQua;
        }
        public List<PHONGTRO> layPhongTheoTang(int boQua, int lay)
        {
            var ketQua = (from phong in ketNoi.PHONGTROs
                          select phong).Skip(boQua).Take(lay).ToList();
            return ketQua;

        }

        public int demPhong()
        {
            try
            {
                var dem = ketNoi.PHONGTROs.Count();
                return dem;

            }
            catch (Exception)
            {

                return 0;
            }
        }
        public bool themPhong(PHONGTRO phong)
        {
            try
            {
                ketNoi.PHONGTROs.InsertOnSubmit(phong);
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
        public bool xoaPhong(string maPhong)
        {
            try
            {
                var ketQua = from phong in ketNoi.PHONGTROs
                             where phong.MAPHONG == maPhong
                             select phong;
                foreach (PHONGTRO phong2 in ketQua)
                {
                    ketNoi.PHONGTROs.DeleteOnSubmit(phong2);
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
