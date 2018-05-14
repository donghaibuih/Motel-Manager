using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_HOADON
    {
        DAL_HOADON dal_hoaDon = new DAL_HOADON();
      
        public bool themHoaDon(HOADON hoaDon){
            return dal_hoaDon.themHoaDon(hoaDon);
        }
       
        public List<HOADON> layHoaDon(){
            return dal_hoaDon.layHoaDon();
        }
        public bool capNhatHoaDon(HOADON hoaDon)
        {
            return dal_hoaDon.capNhatHoaDon(hoaDon);
        }
        public HOADON layHoaDonTheoMaKhach(string maKhach)
        {
            return dal_hoaDon.layHoaDonTheoMaKhach(maKhach);
        }
        public bool xoaHoaDon(string maHoaDon)
        {
            return dal_hoaDon.xoaHoaDon(maHoaDon);
        }
        public int dem()
        {
            return dal_hoaDon.dem();
        }

    }
}
