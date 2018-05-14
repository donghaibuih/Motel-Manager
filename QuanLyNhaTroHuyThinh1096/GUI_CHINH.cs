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
    public partial class GUI_CHINH : MetroForm
    {
        #region khaiBaoBien
        public string phanQuyen = null;
        public NHANVIEN nhanVienDangDangNhap = null;
        public int chucNangDangChon = 0;
        DICHVU dichVu, dichVu1, dichVu2, dichVu3, dichVu4, dichVu5, dichVu6;
        #endregion

        #region khaiBaoBus
        BUS_PHONGTRO bus_phongTro = new BUS_PHONGTRO();
        BUS_HOADON bus_hoaDon = new BUS_HOADON();
        BUS_KHACHTRO bus_khachTro = new BUS_KHACHTRO();
        BUS_CHITIETHOADON bus_chiTietHoaDon = new BUS_CHITIETHOADON();
        BUS_DICHVU bus_dichVu = new BUS_DICHVU();
        BUS_CHITIETPHONG bus_chiTietPhong = new BUS_CHITIETPHONG();
        #endregion

        #region hamKhoiTao
        public GUI_CHINH()
        {
            InitializeComponent();
        }
        public GUI_CHINH(NHANVIEN nhanVien)
        {
            InitializeComponent();
            this.phanQuyen = nhanVien.CHUCVU;
            this.nhanVienDangDangNhap = nhanVien;
        }
        private void GUI_CHINH_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Size = new Size(w, h);
            this.Location = new Point(0, 0);
        }
        private void GUI_CHINH_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void btnShowMennu_Click(object sender, EventArgs e)
        {

            if (pnlMennu.Width == 200)
            {
                for (int i = 200; i >= 60; i--)
                {
                    pnlMennu.Size = new Size(i, pnlMennu.Height);
                }

                btnThuePhong.Text = "";
                btnThuePhong.Width = 58;
                btnThuePhong.Height = 58;

                btnBaoCao.Text = "";
                btnBaoCao.Width = 58;
                btnBaoCao.Height = 58;


                btnDichVu.Text = "";
                btnDichVu.Width = 58;
                btnDichVu.Height = 58;

                btnQuanLyKhach.Text = "";
                btnQuanLyKhach.Width = 58;
                btnQuanLyKhach.Height = 58;

                btnQuanLyNhanVien.Text = "";
                btnQuanLyNhanVien.Width = 58;
                btnQuanLyNhanVien.Height = 58;

                btnQuanLyPhong.Text = "";
                btnQuanLyPhong.Width = 58;
                btnQuanLyPhong.Height = 58;

            }
            else
            {

                for (int i = 60; i <= 200; i++)
                {
                    pnlMennu.Size = new Size(i, pnlMennu.Height);
                }

                btnThuePhong.Text = "Thuê Phòng";
                btnThuePhong.Width = 198;
                btnThuePhong.Height = 76;

                btnBaoCao.Text = "Báo Cáo";
                btnBaoCao.Width = 198;
                btnBaoCao.Height = 76;

                btnDichVu.Text = "Dịch Vụ";
                btnDichVu.Width = 198;
                btnDichVu.Height = 76;

                btnQuanLyKhach.Text = "Khách Trọ";
                btnQuanLyKhach.Width = 198;
                btnQuanLyKhach.Height = 76;

                btnQuanLyNhanVien.Text = "Nhân Viên";
                btnQuanLyNhanVien.Width = 198;
                btnQuanLyNhanVien.Height = 76;

                btnQuanLyPhong.Text = "Phòng Trọ";
                btnQuanLyPhong.Width = 198;
                btnQuanLyPhong.Height = 76;
                pnlMennu.BringToFront();
            }


        }



        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            if (pnlMennu.Width == 200)
            {
                for (int i = 200; i >= 60; i--)
                {
                    pnlMennu.Size = new Size(i, pnlMennu.Height);
                }

                btnThuePhong.Text = "";
                btnThuePhong.Width = 58;
                btnThuePhong.Height = 58;

                btnBaoCao.Text = "";
                btnBaoCao.Width = 58;
                btnBaoCao.Height = 58;


                btnDichVu.Text = "";
                btnDichVu.Width = 58;
                btnDichVu.Height = 58;

                btnQuanLyKhach.Text = "";
                btnQuanLyKhach.Width = 58;
                btnQuanLyKhach.Height = 58;

                btnQuanLyNhanVien.Text = "";
                btnQuanLyNhanVien.Width = 58;
                btnQuanLyNhanVien.Height = 58;

                btnQuanLyPhong.Text = "";
                btnQuanLyPhong.Width = 58;
                btnQuanLyPhong.Height = 58;
            }

            if (chucNangDangChon != 1)
            {
                tabcontrolThuePhong.Visible = true;
                tabcontrolThuePhong.SelectedIndex = 0;
                chucNangDangChon = 1;
                //hien thi danh sach phong
                int dem = bus_phongTro.demPhong();
                List<PHONGTRO> danhSachPhongTangDau;
                hienThiSoTang(tinhSoTang(dem));
                if (dem >= 15)
                {
                    danhSachPhongTangDau = bus_phongTro.layPhongTangDauTien(1, 15);
                    hienThiPhong(danhSachPhongTangDau);
                }
                else
                {
                    danhSachPhongTangDau = bus_phongTro.layPhong();
                    hienThiPhong(danhSachPhongTangDau);
                }

            }


        }
        #region hamCustom

        public void hienThiChiTietHoaDon(string maHoaDon)
        {
            gridChiTietHoaDon.DataSource = bus_chiTietHoaDon.layChiTietHoaDonTheoMaHoaDon(maHoaDon);
            gridChiTietHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            gridChiTietHoaDon.Columns[1].HeaderText = "Tên Dịch Vụ";
            gridChiTietHoaDon.Columns[2].HeaderText = "Số Cũ";
            gridChiTietHoaDon.Columns[3].HeaderText = "Số Lượng";
            gridChiTietHoaDon.Columns[4].HeaderText = "Thành Tiền";
        }
        public void hienThiPhong(List<PHONGTRO> danhSachPhong)
        {
            for (int i = 0; i < danhSachPhong.Count; i++)
            {
                if (danhSachPhong[i] != null)
                {
                    switch (i)
                    {
                        case 0:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong1);
                            break;
                        case 1:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong2);
                            break;
                        case 2:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong3);
                            break;
                        case 3:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong4);
                            break;
                        case 4:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong5);
                            break;
                        case 5:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong6);
                            break;
                        case 6:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong7);
                            break;
                        case 7:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong8);
                            break;
                        case 8:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong9);
                            break;
                        case 9:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong10);
                            break;
                        case 10:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong11);
                            break;
                        case 11:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong12);
                            break;
                        case 12:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong13);
                            break;
                        case 13:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong14);
                            break;
                        case 14:
                            hienThiTrangThaiPhong(danhSachPhong[i], btnPhong15);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public void hienThiTrangThaiPhong(PHONGTRO phong, MetroFramework.Controls.MetroTile nutPhong)
        {
            if (phong != null)
            {
                nutPhong.Text = phong.MAPHONG;
                switch (phong.TRANGTHAI)
                {
                    case "Trống":
                        nutPhong.BackColor = Color.Gray;
                        break;
                    case "Đang Ở":
                        DateTime ngayHienTai = DateTime.Now.Date;
                        KHACHTRO khachTro = bus_khachTro.layKhachTheoMaPhong(phong.MAPHONG);
                        if (khachTro != null)
                        {
                            HOADON hoaDon = bus_hoaDon.layHoaDonTheoMaKhach(khachTro.MAKHACH);
                            if (hoaDon != null)
                            {
                                DateTime ngayCuaHoaDon = hoaDon.NGAYLAP.Date;
                                TimeSpan ketQua = ngayHienTai - ngayCuaHoaDon;
                                if (ketQua.Days >= 30)
                                {
                                    nutPhong.BackColor = Color.Red;
                                }
                                else if (ketQua.Days < 30 && ketQua.Days >= 25)
                                {
                                    nutPhong.BackColor = Color.Gold;
                                }
                                else if (ketQua.Days < 25)
                                {
                                    nutPhong.BackColor = Color.YellowGreen;
                                }
                            }
                        }
                        break;

                }
                nutPhong.Enabled = true;
            }
        }

        public int tinhSoTang(int dem)
        {
            int soTang = 0;
            if (dem != 0)
            {
                if (dem >= 15)
                {
                    int tam = dem % 15;
                    if (tam == 0)
                    {
                        soTang = dem / 15;
                    }
                    else
                    {
                        soTang = (dem / 15) + 1;
                    }

                }
                else
                {
                    soTang = 1;
                }
            }
            return soTang;
        }

        public void hienThiSoTang(int soTang)
        {
            cbbTrang.Items.Clear();
            for (int i = 1; i <= soTang; i++)
            {
                cbbTrang.Items.Add(i);
            }
            cbbTrang.SelectedIndex = 0;
        }

        public void resetTrangThai()
        {
            btnPhong1.BackColor = Color.Gray;
            btnPhong2.BackColor = Color.Gray;
            btnPhong3.BackColor = Color.Gray;
            btnPhong4.BackColor = Color.Gray;
            btnPhong5.BackColor = Color.Gray;
            btnPhong6.BackColor = Color.Gray;
            btnPhong7.BackColor = Color.Gray;
            btnPhong8.BackColor = Color.Gray;
            btnPhong9.BackColor = Color.Gray;
            btnPhong10.BackColor = Color.Gray;
            btnPhong11.BackColor = Color.Gray;
            btnPhong12.BackColor = Color.Gray;
            btnPhong13.BackColor = Color.Gray;
            btnPhong14.BackColor = Color.Gray;
            btnPhong15.BackColor = Color.Gray;

            btnPhong1.Text = "Phòng x";
            btnPhong2.Text = "Phòng x";
            btnPhong3.Text = "Phòng x";
            btnPhong4.Text = "Phòng x";
            btnPhong5.Text = "Phòng x";
            btnPhong6.Text = "Phòng x";
            btnPhong7.Text = "Phòng x";
            btnPhong8.Text = "Phòng x";
            btnPhong9.Text = "Phòng x";
            btnPhong10.Text = "Phòng x";
            btnPhong11.Text = "Phòng x";
            btnPhong12.Text = "Phòng x";
            btnPhong13.Text = "Phòng x";
            btnPhong14.Text = "Phòng x";
            btnPhong15.Text = "Phòng x";

            btnPhong1.Enabled = false;
            btnPhong2.Enabled = false;
            btnPhong3.Enabled = false;
            btnPhong4.Enabled = false;
            btnPhong5.Enabled = false;
            btnPhong6.Enabled = false;
            btnPhong7.Enabled = false;
            btnPhong8.Enabled = false;
            btnPhong9.Enabled = false;
            btnPhong10.Enabled = false;
            btnPhong11.Enabled = false;
            btnPhong12.Enabled = false;
            btnPhong13.Enabled = false;
            btnPhong14.Enabled = false;
            btnPhong15.Enabled = false;
        }

        public void xuLyChonPhong(MetroFramework.Controls.MetroTile nut)
        {
            if (nut.BackColor == Color.YellowGreen)
            {
                gridChiTietHoaDon2.DataSource = null;
                if (gridChiTietHoaDon2.RowCount > 0)
                {
                    gridChiTietHoaDon2.Rows.Clear();
                    gridChiTietHoaDon2.Columns.Clear();
                }
                txtDien.Visible = false;
                txtNuoc.Visible = false;
                label12.Visible = false;
                label17.Visible = false;
                ckcCap.Enabled = false;
                ckcRac.Enabled = false;
                ckcXe.Enabled = false;
                ckcInternet.Enabled = false;
                lblPhong.Text = nut.Text;
                KHACHTRO khach = bus_khachTro.layKhachTheoMaPhong(nut.Text);
                if (khach != null)
                {
                    HOADON hoaDon = bus_hoaDon.layHoaDonTheoMaKhach(khach.MAKHACH);
                    lblMaHoaDon.Text = hoaDon.MAHOADON;
                    txtDiaChiThuongTru.Text = khach.DIACHITHUONGTRU;
                    txtGioiTinh.Text = khach.GIOITINH;
                    txtMaKhach.Text = khach.MAKHACH;
                    txtNgaySinh.Text = khach.NGAYSINH.ToString();
                    txtsoCMND.Text = khach.SOCMND;
                    txtsoDienThoai.Text = khach.SODIENTHOAI;
                    txtTenKhach.Text = khach.TENKHACH;

                    PHONGTRO phong = bus_phongTro.layDoiTuongPhongTheoMaPhong(lblPhong.Text);
                    if (phong != null)
                    {
                        txtSoNguoiO.Text = phong.SONGUOIO.ToString();
                    }


                    gridChiTietHoaDon2.DataSource = bus_chiTietHoaDon.layChiTietHoaDonTheoMaHoaDon(hoaDon.MAHOADON);
                    gridChiTietHoaDon2.Columns[0].HeaderText = "Mã Hóa Đơn";
                    gridChiTietHoaDon2.Columns[1].HeaderText = "Tên Dịch Vụ";
                    gridChiTietHoaDon2.Columns[2].HeaderText = "Số Cũ";
                    gridChiTietHoaDon2.Columns[3].HeaderText = "Số Lượng";
                    gridChiTietHoaDon2.Columns[4].HeaderText = "Thành Tiền";


                    double tongTienDichvu = 0;
                    for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                    {
                        tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                    }
                    lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu.ToString()));
                    PHONGTRO phongTam = bus_phongTro.layDoiTuongPhongTheoMaPhong(nut.Text);
                    if (phongTam != null)
                    {
                        lblTienPhong.Text = string.Format("{0:n}", double.Parse(phongTam.TIENPHONG.ToString()));
                    }
                    lblTongTienHD.Text = string.Format("{0:n}", double.Parse(hoaDon.TONGTIEN.ToString()));

                }
                btnTraPhong.Enabled = true;
                btnThanhToan.Enabled = false;
                btnXacNhanThuePhong.Enabled = false;
                pnlXuLyThuePhong.Visible = true;
            }
            else if (nut.BackColor == Color.Gray)
            {
                gridChiTietHoaDon2.DataSource = null;
                if (gridChiTietHoaDon2.RowCount > 0)
                {
                    gridChiTietHoaDon2.Rows.Clear();
                    gridChiTietHoaDon2.Columns.Clear();
                }
                txtDien.Visible = false;
                txtNuoc.Visible = false;
                label12.Visible = false;
                label17.Visible = false;
                lblPhong.Text = nut.Text;
                lblMaHoaDon.Text = tuSinhMaHoaDon(bus_hoaDon.dem());
                btnThanhToan.Enabled = false;
                btnTraPhong.Enabled = false;
                btnXacNhanThuePhong.Enabled = true;
                pnlXuLyThuePhong.Visible = true;
                ckcCap.Enabled = true;
                ckcRac.Enabled = true;
                ckcXe.Enabled = true;
                ckcInternet.Enabled = true;
                PHONGTRO phong = bus_phongTro.layDoiTuongPhongTheoMaPhong(lblPhong.Text);
                lblTienPhong.Text = phong.TIENPHONG.ToString();
                gridChiTietHoaDon2.Columns.Add("0 ", "Mã hóa đơn");
                gridChiTietHoaDon2.Columns.Add("1", "Tên dịch vụ");
                gridChiTietHoaDon2.Columns.Add("2", "Số cũ");
                gridChiTietHoaDon2.Columns.Add("3", "Số lượng");
                gridChiTietHoaDon2.Columns.Add("4", "Thành tiền");

                gridChiTietHoaDon2.Rows.Add(6);

                dichVu = bus_dichVu.layDoiTuongDichVuBangTenDichVu("Điện");
                gridChiTietHoaDon2.Rows[0].Cells[0].Value = lblMaHoaDon.Text;
                gridChiTietHoaDon2.Rows[0].Cells[1].Value = "Điện";
                gridChiTietHoaDon2.Rows[0].Cells[2].Value = 0;
                gridChiTietHoaDon2.Rows[0].Cells[3].Value = 0;
                gridChiTietHoaDon2.Rows[0].Cells[4].Value = 0;

                dichVu2 = bus_dichVu.layDoiTuongDichVuBangTenDichVu("Nước");
                gridChiTietHoaDon2.Rows[1].Cells[0].Value = lblMaHoaDon.Text;
                gridChiTietHoaDon2.Rows[1].Cells[1].Value = "Nước";
                gridChiTietHoaDon2.Rows[1].Cells[2].Value = 0;
                gridChiTietHoaDon2.Rows[1].Cells[3].Value = 0;
                gridChiTietHoaDon2.Rows[1].Cells[4].Value = 0;

                dichVu3 = bus_dichVu.layDoiTuongDichVuBangTenDichVu("Rác");
                gridChiTietHoaDon2.Rows[2].Cells[0].Value = lblMaHoaDon.Text;
                gridChiTietHoaDon2.Rows[2].Cells[1].Value = "Rác";
                gridChiTietHoaDon2.Rows[2].Cells[2].Value = "";
                gridChiTietHoaDon2.Rows[2].Cells[3].Value = 1;
                gridChiTietHoaDon2.Rows[2].Cells[4].Value = dichVu3.DONGIA * float.Parse(gridChiTietHoaDon2.Rows[2].Cells[3].Value.ToString());

                dichVu4 = bus_dichVu.layDoiTuongDichVuBangTenDichVu("Xe");
                gridChiTietHoaDon2.Rows[3].Cells[0].Value = lblMaHoaDon.Text;
                gridChiTietHoaDon2.Rows[3].Cells[1].Value = "Xe";
                gridChiTietHoaDon2.Rows[3].Cells[2].Value = "";
                gridChiTietHoaDon2.Rows[3].Cells[3].Value = 1;
                gridChiTietHoaDon2.Rows[3].Cells[4].Value = dichVu4.DONGIA * float.Parse(gridChiTietHoaDon2.Rows[3].Cells[3].Value.ToString());

                dichVu5 = bus_dichVu.layDoiTuongDichVuBangTenDichVu("Internet");
                gridChiTietHoaDon2.Rows[4].Cells[0].Value = lblMaHoaDon.Text;
                gridChiTietHoaDon2.Rows[4].Cells[1].Value = "Internet";
                gridChiTietHoaDon2.Rows[4].Cells[2].Value = "";
                gridChiTietHoaDon2.Rows[4].Cells[3].Value = 1;
                gridChiTietHoaDon2.Rows[4].Cells[4].Value = dichVu5.DONGIA * float.Parse(gridChiTietHoaDon2.Rows[4].Cells[3].Value.ToString());

                dichVu6 = bus_dichVu.layDoiTuongDichVuBangTenDichVu("Cáp");
                gridChiTietHoaDon2.Rows[5].Cells[0].Value = lblMaHoaDon.Text;
                gridChiTietHoaDon2.Rows[5].Cells[1].Value = "Cáp";
                gridChiTietHoaDon2.Rows[5].Cells[2].Value = "";
                gridChiTietHoaDon2.Rows[5].Cells[3].Value = 1;
                gridChiTietHoaDon2.Rows[5].Cells[4].Value = dichVu6.DONGIA * float.Parse(gridChiTietHoaDon2.Rows[5].Cells[3].Value.ToString());

                double tongTienDichvu = 0;
                for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                {
                    tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                }
                lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu + ""));
                lblTongTienHD.Text = string.Format("{0:n}", double.Parse((tongTienDichvu + double.Parse(lblTienPhong.Text)).ToString()));

            }
            else if (nut.BackColor == Color.Gold || nut.BackColor == Color.Red)
            {
                ckcCap.Enabled = false;
                ckcRac.Enabled = false;
                ckcXe.Enabled = false;
                ckcInternet.Enabled = false;
                txtDien.Visible = true;
                txtNuoc.Visible = true;
                label12.Visible = true;
                label17.Visible = true;
                lblPhong.Text = nut.Text;
                KHACHTRO khach = bus_khachTro.layKhachTheoMaPhong(nut.Text);
                if (khach != null)
                {
                    HOADON hoaDon = bus_hoaDon.layHoaDonTheoMaKhach(khach.MAKHACH);
                    lblMaHoaDon.Text = hoaDon.MAHOADON;
                    txtDiaChiThuongTru.Text = khach.DIACHITHUONGTRU;
                    txtGioiTinh.Text = khach.GIOITINH;
                    txtMaKhach.Text = khach.MAKHACH;
                    txtNgaySinh.Text = khach.NGAYSINH.ToString();
                    txtsoCMND.Text = khach.SOCMND;
                    txtsoDienThoai.Text = khach.SODIENTHOAI;
                    txtTenKhach.Text = khach.TENKHACH;
                    PHONGTRO phong = bus_phongTro.layDoiTuongPhongTheoMaPhong(lblPhong.Text);
                    if (phong != null)
                    {
                        txtSoNguoiO.Text = phong.SONGUOIO.ToString();
                    }
                    gridChiTietHoaDon2.DataSource = null;
                    if (gridChiTietHoaDon2.RowCount > 0)
                    {
                        gridChiTietHoaDon2.Rows.Clear();
                        gridChiTietHoaDon2.Columns.Clear();
                    }
                    gridChiTietHoaDon2.DataSource = bus_chiTietHoaDon.layChiTietHoaDonTheoMaHoaDon(hoaDon.MAHOADON);
                    gridChiTietHoaDon2.Columns[0].HeaderText = "Mã Hóa Đơn";
                    gridChiTietHoaDon2.Columns[1].HeaderText = "Tên Dịch Vụ";
                    gridChiTietHoaDon2.Columns[2].HeaderText = "Số Cũ";
                    gridChiTietHoaDon2.Columns[3].HeaderText = "Số Lượng";
                    gridChiTietHoaDon2.Columns[4].HeaderText = "Thành Tiền";
                    double tongTienDichvu = 0;
                    for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                    {
                        tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                    }
                    lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu.ToString()));
                    PHONGTRO phongTam = bus_phongTro.layDoiTuongPhongTheoMaPhong(nut.Text);
                    if (phongTam != null)
                    {
                        lblTienPhong.Text = string.Format("{0:n}", double.Parse(phongTam.TIENPHONG.ToString()));
                    }
                    lblTongTienHD.Text = string.Format("{0:n}", double.Parse(hoaDon.TONGTIEN.ToString()));

                }
                btnTraPhong.Enabled = false;
                btnXacNhanThuePhong.Enabled = false;
                btnThanhToan.Enabled = true;
                pnlXuLyThuePhong.Visible = true;
            }
        }

        public string tuSinhMaHoaDon(int dem)
        {
            int ngay = DateTime.Now.Date.Day;
            int thang = DateTime.Now.Date.Month;
            int nam = DateTime.Now.Date.Year;
            string maHoaDon = "HD" + ngay + thang + nam + (dem + 1);
            return maHoaDon;
        }
        #endregion

        private void cbbTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soTang = Int32.Parse(cbbTrang.SelectedIndex.ToString());
            List<PHONGTRO> danhSachPhongTheoTang = bus_phongTro.layPhongTheoTang(soTang * 15, 15);
            resetTrangThai();
            hienThiPhong(danhSachPhongTheoTang);
        }

        private void tabcontrolThuePhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrolThuePhong.SelectedIndex == 1)
            {
                gridHoaDon.DataSource = bus_hoaDon.layHoaDon();

                gridHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
                gridHoaDon.Columns[1].HeaderText = "Mã Khách";
                gridHoaDon.Columns[2].HeaderText = "Mã Nhân Viên";
                gridHoaDon.Columns[3].HeaderText = "Mã Phòng";
                gridHoaDon.Columns[4].HeaderText = "Ngày Lập";
                gridHoaDon.Columns[5].HeaderText = "Tổng Tiền";

                hienThiChiTietHoaDon(gridHoaDon.CurrentRow.Cells[0].Value.ToString());

            }
        }

        private void gridHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                hienThiChiTietHoaDon(gridHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        
        private void lblThoatThuePhong_Click(object sender, EventArgs e)
        {
            txtDiaChiThuongTru.Text = "";
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtsoDienThoai.Text = "";
            txtSoNguoiO.Text = "";
            txtsoCMND.Text = "";
            lblTienPhong.Text = "";
            lblTongTienDichVu.Text = "";
            lblTongTienHD.Text = "";
            pnlXuLyThuePhong.Visible = false;
            label9.Visible = true;
        }

        private void gridChiTietHoaDon2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int soMoi = Int32.Parse(txtDien.Text);
                    int soCu = Int32.Parse(gridChiTietHoaDon2.Rows[0].Cells[2].Value.ToString());
                    int soLuong = soMoi - soCu;
                    DICHVU dichVuTam = bus_dichVu.layDoiTuongDichVuBangTenDichVu("Điện");
                    double thanhTien = soLuong * dichVuTam.DONGIA;

                    gridChiTietHoaDon2.Rows[0].Cells[4].Value = thanhTien;
                    gridChiTietHoaDon2.Rows[0].Cells[3].Value = soLuong;
                    double tongTienDichvu = 0;
                    for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                    {
                        tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                    }
                    lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu + ""));
                    lblTongTienHD.Text = string.Format("{0:n}", double.Parse((tongTienDichvu + double.Parse(lblTienPhong.Text)).ToString()));
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(Owner, "Du lieu khong hop le", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int soMoi = Int32.Parse(txtNuoc.Text);
                    int soCu = Int32.Parse(gridChiTietHoaDon2.Rows[1].Cells[2].Value.ToString());
                    int soLuong = soMoi - soCu;
                    DICHVU dichVuTam = bus_dichVu.layDoiTuongDichVuBangTenDichVu("Nước");
                    double thanhTien = soLuong * dichVuTam.DONGIA;
                    gridChiTietHoaDon2.Rows[1].Cells[4].Value = thanhTien;
                    gridChiTietHoaDon2.Rows[1].Cells[3].Value = soLuong;
                    double tongTienDichvu = 0;
                    for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                    {
                        tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                    }
                    lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu + ""));
                    lblTongTienHD.Text = string.Format("{0:n}", double.Parse((tongTienDichvu + double.Parse(lblTienPhong.Text)).ToString()));
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(Owner, "Du lieu khong hop le", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        #region suKien click
        private void btnPhong1_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong1);
        }

        private void btnPhong2_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong2);
        }

        private void btnPhong3_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong3);
        }

        private void btnPhong4_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong4);
        }

        private void btnPhong5_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong5);
        }

        private void btnPhong6_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong6);
        }

        private void btnPhong7_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong7);
        }

        private void btnPhong8_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong8);
        }

        private void btnPhong9_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong9);
        }
        private void btnPhong10_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong10);
        }
        private void btnPhong11_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong11);
        }

        private void btnPhong12_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong12);
        }

        private void btnPhong13_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong13);
        }

        private void btnPhong14_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong14);
        }

        private void btnPhong15_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            xuLyChonPhong(btnPhong15);
        }
        #endregion 



        #region checked
        private void cbbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ckcRac_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcRac.Checked)
            {
                gridChiTietHoaDon2.Rows[2].Cells[3].Value = 1;
                gridChiTietHoaDon2.Rows[2].Cells[4].Value = dichVu3.DONGIA * float.Parse(gridChiTietHoaDon2.Rows[2].Cells[3].Value.ToString());
                double tongTienDichvu = 0;
                for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                {
                    tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                }
                lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu + ""));
                lblTongTienHD.Text = string.Format("{0:n}", double.Parse((tongTienDichvu + double.Parse(lblTienPhong.Text)).ToString()));
            }
            else
            {
                gridChiTietHoaDon2.Rows[2].Cells[3].Value = 0;
                gridChiTietHoaDon2.Rows[2].Cells[4].Value = dichVu3.DONGIA * float.Parse(gridChiTietHoaDon2.Rows[2].Cells[3].Value.ToString());
                double tongTienDichvu = 0;
                for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                {
                    tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                }
                lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu + ""));
                lblTongTienHD.Text = string.Format("{0:n}", double.Parse((tongTienDichvu + double.Parse(lblTienPhong.Text)).ToString()));
            }
        }

        private void ckcCap_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcCap.Checked)
            {
                gridChiTietHoaDon2.Rows[5].Cells[3].Value = 1;
                gridChiTietHoaDon2.Rows[5].Cells[4].Value = dichVu6.DONGIA * float.Parse(gridChiTietHoaDon2.Rows[5].Cells[3].Value.ToString());
                double tongTienDichvu = 0;
                for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                {
                    tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                }
                lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu + ""));
                lblTongTienHD.Text = string.Format("{0:n}", double.Parse((tongTienDichvu + double.Parse(lblTienPhong.Text)).ToString()));
            }
            else
            {
                gridChiTietHoaDon2.Rows[5].Cells[3].Value = 0;
                gridChiTietHoaDon2.Rows[5].Cells[4].Value = dichVu6.DONGIA * float.Parse(gridChiTietHoaDon2.Rows[5].Cells[3].Value.ToString());
                double tongTienDichvu = 0;
                for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                {
                    tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                }
                lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu + ""));
                lblTongTienHD.Text = string.Format("{0:n}", double.Parse((tongTienDichvu + double.Parse(lblTienPhong.Text)).ToString()));
            }
        }

        private void ckcInternet_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcInternet.Checked)
            {
                gridChiTietHoaDon2.Rows[4].Cells[3].Value = 1;
                gridChiTietHoaDon2.Rows[4].Cells[4].Value = dichVu5.DONGIA * float.Parse(gridChiTietHoaDon2.Rows[4].Cells[3].Value.ToString());
                double tongTienDichvu = 0;
                for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                {
                    tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                }
                lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu + ""));
                lblTongTienHD.Text = string.Format("{0:n}", double.Parse((tongTienDichvu + double.Parse(lblTienPhong.Text)).ToString()));
            }
            else
            {
                gridChiTietHoaDon2.Rows[4].Cells[3].Value = 0;
                gridChiTietHoaDon2.Rows[4].Cells[4].Value = dichVu5.DONGIA * float.Parse(gridChiTietHoaDon2.Rows[4].Cells[3].Value.ToString());
                double tongTienDichvu = 0;
                for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                {
                    tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                }
                lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu + ""));
                lblTongTienHD.Text = string.Format("{0:n}", double.Parse((tongTienDichvu + double.Parse(lblTienPhong.Text)).ToString()));
            }
        }

        private void ckcXe_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcXe.Checked)
            {
                gridChiTietHoaDon2.Rows[3].Cells[3].Value = 1;
                gridChiTietHoaDon2.Rows[3].Cells[4].Value = dichVu4.DONGIA * float.Parse(gridChiTietHoaDon2.Rows[3].Cells[3].Value.ToString());
                double tongTienDichvu = 0;
                for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                {
                    tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                }
                lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu + ""));
                lblTongTienHD.Text = string.Format("{0:n}", double.Parse((tongTienDichvu + double.Parse(lblTienPhong.Text)).ToString()));
            }
            else
            {
                gridChiTietHoaDon2.Rows[3].Cells[3].Value = 0;
                gridChiTietHoaDon2.Rows[3].Cells[4].Value = dichVu4.DONGIA * float.Parse(gridChiTietHoaDon2.Rows[3].Cells[3].Value.ToString());
                double tongTienDichvu = 0;
                for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
                {
                    tongTienDichvu += double.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString());
                }
                lblTongTienDichVu.Text = string.Format("{0:n}", double.Parse(tongTienDichvu + ""));
                lblTongTienHD.Text = string.Format("{0:n}", double.Parse((tongTienDichvu + double.Parse(lblTienPhong.Text)).ToString()));
            }
        }
        #endregion


        #region thuePhong
        private void btnXacNhanThuePhong_Click(object sender, EventArgs e)
        {
            string diaChiThuongTru = txtDiaChiThuongTru.Text;
            string gioiTinh = txtGioiTinh.SelectedItem.ToString();
            string maKhach = txtMaKhach.Text;
            DateTime ngaySinh = txtNgaySinh.Value.Date;
            string soCMND = txtsoCMND.Text;
            string soDienThoai = txtsoDienThoai.Text;
            string tenKhach = txtTenKhach.Text;
            string maPhong = lblPhong.Text;

            KHACHTRO khachThuePhong = new KHACHTRO(maKhach, tenKhach, maPhong, ngaySinh, gioiTinh, soDienThoai, diaChiThuongTru, soCMND);
            HOADON hoaDonThue = new HOADON(lblMaHoaDon.Text, maKhach, nhanVienDangDangNhap.MANHANVIEN, lblPhong.Text, DateTime.Now.Date, double.Parse(lblTongTienHD.Text));

            bus_hoaDon.themHoaDon(hoaDonThue);
            bus_khachTro.themKhach(khachThuePhong);
            PHONGTRO phong = new PHONGTRO(maPhong, "Đang Ở", float.Parse(lblTienPhong.Text), Int32.Parse(txtSoNguoiO.Text));
            bus_phongTro.capNhatPhong(phong);
            for (int i = 0; i < gridChiTietHoaDon2.RowCount; i++)
            {
                CHITIETHOADON chiTietHoaDon = new CHITIETHOADON(gridChiTietHoaDon2.Rows[i].Cells[0].Value.ToString(), gridChiTietHoaDon2.Rows[i].Cells[1].Value.ToString(), 0, Int32.Parse(gridChiTietHoaDon2.Rows[i].Cells[3].Value.ToString()), float.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString()));
                bus_chiTietHoaDon.themChiTietHoaDon(chiTietHoaDon);
            }
            MetroMessageBox.Show(Owner, "Thue Thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            int soTang = Int32.Parse(cbbTrang.SelectedIndex.ToString());
            List<PHONGTRO> danhSachPhongTheoTang = bus_phongTro.layPhongTheoTang(soTang * 15, 15);
            resetTrangThai();
            hienThiPhong(danhSachPhongTheoTang);

            txtDiaChiThuongTru.Text = "";
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtsoDienThoai.Text = "";
            txtSoNguoiO.Text = "";
            txtsoCMND.Text = "";
            lblTienPhong.Text = "";
            lblTongTienDichVu.Text = "";
            lblTongTienHD.Text = "";
            pnlXuLyThuePhong.Visible = false;
        }
        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            bus_khachTro.xoaKhach(txtMaKhach.Text);
            bus_chiTietPhong.xoaChiTietPhong(lblPhong.Text);
            bus_hoaDon.xoaHoaDon(lblMaHoaDon.Text);
            bus_chiTietHoaDon.xoaChiTietHoaDon(lblMaHoaDon.Text);
            PHONGTRO phongTam = bus_phongTro.layDoiTuongPhongTheoMaPhong(lblPhong.Text);
            string tam = "Trống";
            phongTam.TRANGTHAI = tam;
            bus_phongTro.capNhatPhong(phongTam);

            MetroMessageBox.Show(Owner, "Tra phong thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //capnhat lai trang thai
            int soTang = Int32.Parse(cbbTrang.SelectedIndex.ToString());
            bus_phongTro.capNhatSoNguoiTrongPhong(lblPhong.Text, Int32.Parse(txtSoNguoiO.Text));
            List<PHONGTRO> danhSachPhongTheoTang = bus_phongTro.layPhongTheoTang(soTang * 15, 15);
            resetTrangThai();
            hienThiPhong(danhSachPhongTheoTang);

            txtDiaChiThuongTru.Text = "";
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtsoDienThoai.Text = "";
            txtSoNguoiO.Text = "";
            txtsoCMND.Text = "";
            lblTienPhong.Text = "";
            lblTongTienDichVu.Text = "";
            lblTongTienHD.Text = "";
            pnlXuLyThuePhong.Visible = false;

        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            gridChiTietHoaDon2.Rows[0].Cells[2].Value = txtDien.Text;
            gridChiTietHoaDon2.Rows[1].Cells[2].Value = txtNuoc.Text;
            bool kiemTra = true;
            HOADON hoaDon = new HOADON(lblMaHoaDon.Text, txtMaKhach.Text, nhanVienDangDangNhap.MANHANVIEN, lblPhong.Text, DateTime.Now.Date, double.Parse(lblTongTienHD.Text));
            bus_hoaDon.capNhatHoaDon(hoaDon);
            List<CHITIETHOADON> danhSachChiTietHoaDon = new List<CHITIETHOADON>();
            for (int i = 0; i < gridChiTietHoaDon.RowCount; i++)
            {
                CHITIETHOADON chiTietHoaDon = new CHITIETHOADON(lblMaHoaDon.Text, gridChiTietHoaDon2.Rows[i].Cells[0].Value.ToString(), Int32.Parse(gridChiTietHoaDon2.Rows[i].Cells[2].Value.ToString()), Int32.Parse(gridChiTietHoaDon2.Rows[i].Cells[3].Value.ToString()), float.Parse(gridChiTietHoaDon2.Rows[i].Cells[4].Value.ToString()));
                if (chiTietHoaDon != null)
                {
                    danhSachChiTietHoaDon.Add(chiTietHoaDon);
                }
                else
                {
                    kiemTra = false;
                    break;
                }
            }
            if (kiemTra)
            {
                foreach (CHITIETHOADON chitietTam in danhSachChiTietHoaDon)
                {
                    bus_chiTietHoaDon.capNhatChiTietHoaDon(chitietTam);
                }
                MetroMessageBox.Show(Owner, "Thanh toan thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //capnhat lai trang thai
                int soTang = Int32.Parse(cbbTrang.SelectedIndex.ToString());
                bus_phongTro.capNhatSoNguoiTrongPhong(lblPhong.Text, Int32.Parse(txtSoNguoiO.Text));
                List<PHONGTRO> danhSachPhongTheoTang = bus_phongTro.layPhongTheoTang(soTang * 15, 15);
                resetTrangThai();
                hienThiPhong(danhSachPhongTheoTang);

                txtDiaChiThuongTru.Text = "";
                txtMaKhach.Text = "";
                txtTenKhach.Text = "";
                txtsoDienThoai.Text = "";
                txtSoNguoiO.Text = "";
                txtsoCMND.Text = "";
                lblTienPhong.Text = "";
                lblTongTienDichVu.Text = "";
                lblTongTienHD.Text = "";
                pnlXuLyThuePhong.Visible = false;
            }
            else
            {
                MetroMessageBox.Show(Owner, "Thanh toan that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXoaKhach_Click(object sender, EventArgs e)
        {
            ;
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            GUI_PHONGTRO phongTro = new GUI_PHONGTRO();
            phongTro.Show();
        }

        
    }
}
