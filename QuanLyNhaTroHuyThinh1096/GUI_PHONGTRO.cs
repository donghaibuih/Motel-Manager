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
using BUS;
using DAL;

namespace QuanLyNhaTroHuyThinh1096
{
    public partial class GUI_PHONGTRO : MetroForm
    {
        BUS_PHONGTRO bus_phongTro = new BUS_PHONGTRO();
        BUS_CHITIETPHONG bus_chiTietPhongTro = new BUS_CHITIETPHONG();
        public GUI_PHONGTRO()
        {
            InitializeComponent();
        }

        private void GUI_PHONGTRO_Load(object sender, EventArgs e)
        {
            gridPhong.DataSource = bus_phongTro.layPhong();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Size = new Size(w, h);
            this.Location = new Point(0, 0);

        }

        private void tabPhongTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridPhong.DataSource = bus_phongTro.layPhong();
            gridChiTietPhong.DataSource = bus_chiTietPhongTro.layChiTietPhong();
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            string maPhong = gridPhong.CurrentRow.Cells[0].Value.ToString();
            bus_phongTro.xoaPhong(maPhong);
            bus_phongTro.layPhong();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            string maPhong = txtmaPhong.Text;
            int soNguoiO = Int32.Parse(txtSoNguoiO.Text);
            double tienPhong = double.Parse(txtTienPhong.Text);
            string trangThai = boxTrangThai.SelectedItem.ToString();

            PHONGTRO phong = new PHONGTRO(maPhong, trangThai, tienPhong, soNguoiO);
            bus_phongTro.themPhong(phong);
            bus_phongTro.layPhong();
            MetroMessageBox.Show(Owner, "Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
