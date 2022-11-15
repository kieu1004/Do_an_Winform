﻿using Do_an_Winform.BLL;
using Do_an_Winform.DTO;
using Do_an_Winform.PL.Quanly.QLDoiTac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly.DoiTac
{
    public partial class frm_DoiTacNCC : Form
    {
        public frm_DoiTacNCC()
        {
            InitializeComponent();
            Refresh();
        }

        private void frm_DoiTacNCC_Load(object sender, EventArgs e)
        {
            dgNhaCungCap.DataSource = NhaCungCapBLL.GetAllSupplier();
            dgNhaCungCap.ReadOnly = true;
            dgNhaCungCap.AllowUserToResizeColumns = false;
            dgNhaCungCap.AllowUserToResizeRows = false;

            dgNhaCungCap.Columns[0].Visible = false;
            dgNhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgNhaCungCap.Columns[2].HeaderText = "Số điện thoại";
            dgNhaCungCap.Columns[3].HeaderText = "Email";
            dgNhaCungCap.Columns[4].HeaderText = "Địa chỉ";
            dgNhaCungCap.Columns[5].Visible = false;

        }

        private void btThemNCC_Click(object sender, EventArgs e)
        {
            frm_InsertNCC form = new frm_InsertNCC();
            form.ShowDialog();
            dgNhaCungCap.DataSource = NhaCungCapBLL.GetAllSupplier();
        }

        private void txtFind_TextChange(object sender, EventArgs e)
        {
            try
            {
                dgNhaCungCap.DataSource = NhaCungCapBLL.GetAllSupplierByName(txtFind.Text);
                dgNhaCungCap.Columns[0].Visible = false;
                dgNhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";
                dgNhaCungCap.Columns[2].HeaderText = "Số điện thoại";
                dgNhaCungCap.Columns[3].HeaderText = "Email";
                dgNhaCungCap.Columns[4].HeaderText = "Địa chỉ";
                dgNhaCungCap.Columns[5].Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void btnCreateRP_Click(object sender, EventArgs e)
        {
            frm_BaoCaoDoiTac form = new frm_BaoCaoDoiTac("nhacungcap");
            form.ShowDialog();
        }
    }
}
