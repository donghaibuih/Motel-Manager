using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DICHVU : CONNECT
    {
        public bool capNhatDichVu(DICHVU dichVu)
        {
            try
            {
                var ketQua = from dichVuTam in ketNoi.DICHVUs
                             where dichVuTam.TENDICHVU == dichVu.TENDICHVU
                             select dichVuTam;
                foreach (var tam in ketQua)
                {
                    tam.DONGIA = dichVu.DONGIA;
                    tam.DONVITINH = dichVu.DONVITINH;


                }
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;

            }


        }
        public List<DICHVU> layDichVu()
        {
            var ketQua = (from dichVu in ketNoi.DICHVUs
                          select dichVu).ToList();
            return ketQua;
        }
        public bool themDichVu(DICHVU dichVu)
        {
            try
            {
                ketNoi.DICHVUs.InsertOnSubmit(dichVu);
                ketNoi.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public DICHVU layDoiTuongDichVuBangTenDichVu(string tenDichVu)
        {
            try
            {
                var ketQua = (from dichVuTam in ketNoi.DICHVUs
                              where dichVuTam.TENDICHVU == tenDichVu
                              select dichVuTam).FirstOrDefault();
                return ketQua;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool xoaDichVu(string tenDichVu)
        {
            try
            {
                var ketQua = from dichVu in ketNoi.DICHVUs
                             where dichVu.TENDICHVU == tenDichVu
                             select dichVu;
                foreach (DICHVU dichVuTam in ketQua)
                {
                    ketNoi.DICHVUs.DeleteOnSubmit(dichVuTam);
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
