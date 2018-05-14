using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class DICHVU
    {
        public DICHVU(string tenDichVu, string donViTinh, double donGia)
        {
            this.TENDICHVU = tenDichVu;
            this.DONGIA = donGia;
            this.DONVITINH = donViTinh;
        }
    }
}
