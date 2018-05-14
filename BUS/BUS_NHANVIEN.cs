using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
   public class BUS_NHANVIEN
    {
       DAL_NHANVIEN dal_nhanVien = new DAL_NHANVIEN();
       public NHANVIEN layNhanVienTheoMaNhanVien(string maNhanVien)
       {
           return dal_nhanVien.layNhanVienTheoMaNhanVien(maNhanVien);
       }
       public bool xoaNhanVien(string maNhanVien)
       {
           return dal_nhanVien.xoaNhanVien(maNhanVien);
       }
       public bool themNhanVien(NHANVIEN nhanVien)
       {
           return dal_nhanVien.themNhanVien(nhanVien);

       }
       public List<NHANVIEN> layNhanVien()
       {
           return dal_nhanVien.layNhanVien();

       }
       public bool capNhatNhanVien(NHANVIEN nhanVien)
       {
           return dal_nhanVien.capNhatNhanVien(nhanVien);

       }


    }
}
