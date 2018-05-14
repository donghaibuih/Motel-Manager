using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_CHITIETHOADON
    {
        DAL_CHITIETHOADON dal_chiTietHoaDon = new DAL_CHITIETHOADON();
        public List<CHITIETHOADON> layChiTietHoaDon(){
            return dal_chiTietHoaDon.layChiTietHoaDon();
        }
        public bool themChiTietHoaDon(CHITIETHOADON chiTietHoaDon){
            return dal_chiTietHoaDon.themChiTietHoaDon(chiTietHoaDon);
        }
        public bool xoaChiTietHoaDon(string maHoaDon){
            return dal_chiTietHoaDon.xoaChiTietHoaDon(maHoaDon);
        }
        public bool capNhatChiTietHoaDon(CHITIETHOADON chiTietHoaDon)
        {
            return dal_chiTietHoaDon.capNhatChiTietHoaDon(chiTietHoaDon);
        }
        public List<CHITIETHOADON> layChiTietHoaDonTheoMaHoaDon(string maHoaDon)
        {
            return dal_chiTietHoaDon.layChiTietHoaDonTheoMaHoaDon(maHoaDon);
        }
    }
}
