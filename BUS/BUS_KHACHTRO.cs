using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_KHACHTRO
    {
        DAL_KHACHTRO dal_khachTro = new DAL_KHACHTRO();
        public bool xoaKhach(string maKhach){
            return dal_khachTro.xoaKhach(maKhach);
        }
        public bool themKhach(KHACHTRO khach){
            return dal_khachTro.themKhach(khach);
        }
        public List<KHACHTRO> layKhach(){
            return dal_khachTro.layKhach();
        }
        public bool capNhatKhachTro(KHACHTRO khach)
        {
            return dal_khachTro.capNhatKhachTro(khach);
        }
        public KHACHTRO layKhachTheoMaPhong(string maPhong)
        {
            return dal_khachTro.layKhachTheoMaPhong(maPhong);
        }
    }
}
