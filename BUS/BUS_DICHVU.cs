using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_DICHVU
    {
        DAL_DICHVU dal_DichVu = new DAL_DICHVU();

        public List<DICHVU> layDichVu(){
            return dal_DichVu.layDichVu();
        }
        public bool themDichVu(DICHVU dichVu){
            return dal_DichVu.themDichVu(dichVu);
        }
         public bool xoaDichVu(string tenDichVu){
             return dal_DichVu.xoaDichVu(tenDichVu);

            }
         public bool capNhatDichVu(DICHVU dichVu)
         {
             return dal_DichVu.capNhatDichVu(dichVu);
         }
         public DICHVU layDoiTuongDichVuBangTenDichVu(string tenDichVu)
         {
             return dal_DichVu.layDoiTuongDichVuBangTenDichVu(tenDichVu);
         }
    }
}
