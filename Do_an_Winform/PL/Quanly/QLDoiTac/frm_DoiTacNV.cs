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
    public partial class frm_DoiTacNV : Form
    {
        public frm_DoiTacNV()
        {
            InitializeComponent();
        }

        private void frm_DoiTacNV_Load(object sender, EventArgs e)
        {
            dgNhanVien.DataSource = NhanVienBLL.GetAllEmployee();

            dgNhanVien.ReadOnly = true;
            dgNhanVien.AllowUserToResizeColumns = false;
            dgNhanVien.AllowUserToResizeRows = false;

            dgNhanVien.Columns[0].Visible = false;
            dgNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgNhanVien.Columns[2].HeaderText = "Giới tính";
            dgNhanVien.Columns[3].HeaderText = "Email";
            dgNhanVien.Columns[4].HeaderText = "Số điện thoại";
            dgNhanVien.Columns[5].HeaderText = "Địa chỉ";
            dgNhanVien.Columns[6].HeaderText = "Loại nhân viên";
            dgNhanVien.Columns[7].HeaderText = "Tài khoản";
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TaoTaiKhoan());
        }

        private void txtFind_TextChange(object sender, EventArgs e)
        {
            try
            {
                dgNhanVien.DataSource = NhanVienBLL.GetEmployeeByName(txtFind.Text);

                dgNhanVien.Columns[0].Visible = false;
                dgNhanVien.Columns[1].HeaderText = "Tên nhân viên";
                dgNhanVien.Columns[2].HeaderText = "Giới tính";
                dgNhanVien.Columns[3].HeaderText = "Email";
                dgNhanVien.Columns[4].HeaderText = "Số điện thoại";
                dgNhanVien.Columns[5].HeaderText = "Địa chỉ";
                dgNhanVien.Columns[6].HeaderText = "Loại nhân viên";
                dgNhanVien.Columns[7].HeaderText = "Tài khoản";
            }
            catch (Exception)
            {

            }
        }

        private void btnCreateRP_Click(object sender, EventArgs e)
        {
            frm_BaoCaoDoiTac form = new frm_BaoCaoDoiTac("nhanvien");
            form.ShowDialog();   
        }
    }
}
