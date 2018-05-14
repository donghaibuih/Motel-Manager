using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_PHONGTRO
    {
        DAL_PHONGTRO dal_phongTro = new DAL_PHONGTRO();
        public bool xoaPhong(string maPhong)
        {
            return dal_phongTro.xoaPhong(maPhong);
        }
        public int demPhong()
        {
            return dal_phongTro.demPhong();
        }
        public bool themPhong(PHONGTRO phong)
        {
            return dal_phongTro.themPhong(phong);
        }
        public List<PHONGTRO> layPhong()
        {
            return dal_phongTro.layPhong();

        }
        public List<PHONGTRO> layPhongTangDauTien(int batDau, int ketThuc)
        {
            return dal_phongTro.layPhongTangDauTien(batDau, ketThuc);
        }
        public bool capNhatPhong(PHONGTRO phong)
        {
            return dal_phongTro.capNhatPhong(phong);

        }
        public List<PHONGTRO> layPhongTheoTang(int boQua, int lay)
        {
            return dal_phongTro.layPhongTheoTang(boQua, lay);
        }
        public PHONGTRO layDoiTuongPhongTheoMaPhong(string maPhong)
        {
            return dal_phongTro.layDoiTuongPhongTheoMaPhong(maPhong);
        }
        public bool capNhatSoNguoiTrongPhong(string maPhong, int soNguoi)
        {
            return dal_phongTro.capNhatSoNguoiTrongPhong(maPhong, soNguoi);
        }
    }
}
