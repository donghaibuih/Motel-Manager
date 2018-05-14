using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_CHITIETPHONG
    {
        DAL_CHITIETPHONG dal_chiTietPhong = new DAL_CHITIETPHONG();

        public bool capNhatChiTietPhong(CHITIETPHONG chiTietPhong)
        {
            return dal_chiTietPhong.capNhatChiTietPhong(chiTietPhong);
        }
        public List<CHITIETPHONG> layChiTietPhong()
        {
            return dal_chiTietPhong.layChiTietPhong();
        }
        public bool xoaChiTietPhong(string maPhong)
        {
            return dal_chiTietPhong.xoaChiTietPhong(maPhong);
        }
        public bool themChiTietPhong(CHITIETPHONG chiTietPhong)
        {
            return dal_chiTietPhong.themChiTietPhong(chiTietPhong);
        }
    }
}
