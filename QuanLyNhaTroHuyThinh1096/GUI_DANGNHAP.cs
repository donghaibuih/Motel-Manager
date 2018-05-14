using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using DAL;
using BUS;


namespace QuanLyNhaTroHuyThinh1096
{
    public partial class GUI_DANGNHAP : MetroForm
    {
        #region khoiTaoBus
        BUS_TAIKHOAN bus_taiKhoan = new BUS_TAIKHOAN();
        BUS_NHANVIEN bus_nhanVien = new BUS_NHANVIEN();
        #endregion
      
        #region hamKhoiTao
        public GUI_DANGNHAP()
        {
            InitializeComponent();
        }

        private void GUI_DANGNHAP_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Size = new Size(w, h);
            this.Location = new Point(0, 0);
        }

        #endregion

        #region controlBox
        private void lblThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region xuLySuKienDangNhap
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dangNhap();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dangNhap();
        }
        #endregion

        #region hamDangNhap
        public void dangNhap()
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            if (bus_taiKhoan.dangNhap(tenDangNhap, matKhau))
            {
                TAIKHOAN taiKhoan = bus_taiKhoan.layTaiKhoanTheoTenTaiKhoan(tenDangNhap);
                if (taiKhoan != null)
                {
                    NHANVIEN nhanVien = bus_nhanVien.layNhanVienTheoMaNhanVien(taiKhoan.MANHANVIEN);
                    if (nhanVien != null)
                    {
                        GUI_CHINH giaoDienChinh = new GUI_CHINH(nhanVien);
                        giaoDienChinh.Show();
                        this.Visible = false;
                    }
                    else
                        MetroMessageBox.Show(Owner, "Nhân Viên Không Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetroMessageBox.Show(Owner, "Tài Khoản Không Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MetroMessageBox.Show(Owner, "Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}
