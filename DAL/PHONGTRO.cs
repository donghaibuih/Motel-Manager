using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class PHONGTRO
    {
        public PHONGTRO(string maPhong, string trangThai, double tienPhong, int soNguoiO)
        {
            this.MAPHONG = maPhong;
            this.TRANGTHAI = trangThai;
            this.TIENPHONG = tienPhong;
            this.SONGUOIO = soNguoiO;
        }
    }
}
