﻿using System;
using Do_an_Winform.PL.DangNhap;
using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly.QLSP
{
    public partial class frm_Insert : Form
    {
        public frm_Insert()
        {
            InitializeComponent();
        }

        private void frm_Insert_Load(object sender, EventArgs e)
        {
            List<NhaSanXuatDTO> nsx = NhaSanXuatBLL.GetAllManufac();
            nsx.RemoveAt(0);
            cbNSX.DataSource = nsx;
            cbNSX.DisplayMember = "TenNhaSX";
            cbNSX.ValueMember = "MaNhaSX";

            List<LoaiSanPhamDTO> lsp = LoaiSanPhamBLL.GetAllCat();
            lsp.RemoveAt(0);
            cbLoaisp.DataSource = lsp;
            cbLoaisp.DisplayMember = "TenLoaiSP";
            cbLoaisp.ValueMember = "MaLoaiSP";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessBox messBox = new MessBox();
            bool result = messBox.ShowMess("Bạn có muốn hủy thêm sản phẩm mới ?");
            if (result)
            {
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTensp.Text == "" || txtDongia.Text == "")
            {
                bunifuSnackbar1.Show(this, "Vui lòng nhập đủ thông tin vào ô trống", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }
            else
            {
                SanPhamDTO product = new SanPhamDTO();
                product.TenSP = txtTensp.Text;
                product.SoLuong = 1;
                product.DonGia = int.Parse(txtDongia.Text);
                product.MaLoaiSP = cbLoaisp.SelectedValue.ToString();
                product.MaNhaSX = cbNSX.SelectedValue.ToString();
                product.TrangThai = "1";

                MessBox messBox = new MessBox();
                bool result = messBox.ShowMess("Bạn có muốn thêm sản phẩm mới không ?");
                if (result)
                {
                    if (SanPhamBLL.InsertProduct(product))
                    {
                        bunifuSnackbar1.Show(new frm_QLSP(), "Bạn đã thêm sản phẩm mới thành công", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        Close();
                    }
                }
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
