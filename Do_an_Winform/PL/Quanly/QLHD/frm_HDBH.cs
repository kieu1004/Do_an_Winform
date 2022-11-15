﻿using Do_an_Winform.BLL;
using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using Do_an_Winform.PL.Quanly.BaoCao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Quanly
{
    public partial class frm_HDBH : Form
    {
        DateTime startday, endday;
        List<HoaDonDTO> listhd;
        TaiKhoanDTO user = new TaiKhoanDTO();

        public frm_HDBH()
        {
            InitializeComponent();
            gvHDBH.AllowUserToResizeColumns = false;
            gvHDBH.AllowUserToResizeRows = false;
            gvHDBH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvHDBH.ReadOnly = true;
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void frm_HDBH_Load(object sender, EventArgs e)
        {
            //auto complete
            List<object> listmahd = HoaDonBLL.LayTatCaMaHD();
            AutoCompleteStringCollection automahd = new AutoCompleteStringCollection();
            foreach (object i in listmahd)
            {
                automahd.Add(i.ToString());
            }
            txtSearch.AutoCompleteCustomSource = automahd;

            //load Date
            DatePickerStartDay.Value = System.DateTime.Now;
            DatePickerEndDay.Value = System.DateTime.Now;

            gvHDBH.AllowUserToResizeColumns = false;
            gvHDBH.AllowUserToResizeRows = false;

            listhd = HoaDonBLL.ThongKeTatCaHD(DatePickerStartDay.Value, DatePickerEndDay.Value);
            gvHDBH.DataSource = listhd;
            gvHDBH.Columns[0].HeaderText = "Mã HD";
            gvHDBH.Columns[1].HeaderText = "Ngày lập HD";
            gvHDBH.Columns[2].HeaderText = "Mã NV";
            gvHDBH.Columns[3].HeaderText = "Mã KH";
            gvHDBH.Columns[4].HeaderText = "Thành tiền";
            gvHDBH.Columns[5].Visible = false;
            txtTongCong.Text = HoaDonBLL.ThongKeDoanhThuTheoTDHT(DateTime.Now).ToString();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm mã hóa đơn")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm mã hóa đơn";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                startday = DatePickerStartDay.Value;
                endday = DatePickerEndDay.Value;

                if (endday < startday)
                {
                    bunifuSnackbarHDBH.Show(new frm_Quanly(user), "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            catch (Exception)
            {
                bunifuSnackbarHDBH.Show(new frm_Quanly(user), "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            if (txtSearch.Text.Trim() != "")
            {               
                listhd = HoaDonBLL.TKTheoMaHD(txtSearch.Text, DateTime.Today);
                foreach (HoaDonDTO pn in listhd)
                {
                    DatePickerStartDay.Value = pn.NgayTaoHD;
                    DatePickerEndDay.Value = DateTime.Now;
                }
                gvHDBH.DataSource = listhd;
                gvHDBH.Columns[0].HeaderText = "Mã HD";
                gvHDBH.Columns[1].HeaderText = "Ngày lập HD";
                gvHDBH.Columns[2].HeaderText = "Mã NV";
                gvHDBH.Columns[3].HeaderText = "Mã KH";
                gvHDBH.Columns[4].HeaderText = "Thành tiền";
                gvHDBH.Columns[5].Visible = false;
                txtTongCong.Text = HoaDonBLL.DoanhThuTheoMaHD(txtSearch.Text, DateTime.Today).ToString();
            }
            else
            {
                listhd = HoaDonBLL.ThongKeTatCaHD(startday, endday);
                gvHDBH.DataSource = listhd;
                gvHDBH.Columns[0].HeaderText = "Mã HD";
                gvHDBH.Columns[1].HeaderText = "Ngày lập HD";
                gvHDBH.Columns[2].HeaderText = "Mã NV";
                gvHDBH.Columns[3].HeaderText = "Mã KH";
                gvHDBH.Columns[4].HeaderText = "Thành tiền";
                gvHDBH.Columns[5].Visible = false;
                txtTongCong.Text = HoaDonBLL.DoanhThuTatCaHD(startday, endday).ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                startday = DatePickerStartDay.Value;
                endday = DatePickerEndDay.Value;

                if (endday < startday)
                {
                    bunifuSnackbarHDBH.Show(this, "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            catch (Exception)
            {
                bunifuSnackbarHDBH.Show(this, "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            //Kiểm tra txtSearch có phải là số hay không?
            int Result; 
            bool isSuccess; 

            isSuccess = int.TryParse(txtSearch.Text, out Result);
            if(isSuccess == true)
            {
                int mahd = int.Parse(txtSearch.Text);
                string s = "HD" + mahd.ToString("000");
                foreach (HoaDonDTO pn in listhd)
                {
                    DatePickerStartDay.Value = pn.NgayTaoHD;
                    DatePickerEndDay.Value = DateTime.Now;
                }
                gvHDBH.DataSource = listhd;
                gvHDBH.Columns[0].HeaderText = "Mã HD";
                gvHDBH.Columns[1].HeaderText = "Ngày lập HD";
                gvHDBH.Columns[2].HeaderText = "Mã NV";
                gvHDBH.Columns[3].HeaderText = "Mã KH";
                gvHDBH.Columns[4].HeaderText = "Thành tiền";
                gvHDBH.Columns[5].Visible = false;
                txtTongCong.Text = HoaDonBLL.DoanhThuTheoMaHD(s, DateTime.Today).ToString();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            listhd = HoaDonBLL.TKTheoMaHD(txtSearch.Text, DateTime.Today);
            foreach (HoaDonDTO pn in listhd)
            {
                DatePickerStartDay.Value = pn.NgayTaoHD;
                DatePickerEndDay.Value = DateTime.Now;
            }
            gvHDBH.DataSource = listhd;
            gvHDBH.Columns[0].HeaderText = "Mã HD";
            gvHDBH.Columns[1].HeaderText = "Ngày lập HD";
            gvHDBH.Columns[2].HeaderText = "Mã NV";
            gvHDBH.Columns[3].HeaderText = "Mã KH";
            gvHDBH.Columns[4].HeaderText = "Thành tiền";
            gvHDBH.Columns[5].Visible = false;
            txtTongCong.Text = HoaDonBLL.DoanhThuTheoMaHD(txtSearch.Text, DateTime.Today).ToString();
        }

        private void DatePickerEndDay_CloseUp(object sender, EventArgs e)
        {
            DateTime startday = DatePickerStartDay.Value;
            DateTime endday = DatePickerEndDay.Value;
            if (startday <= endday)
            {
                listhd = HoaDonBLL.ThongKeTatCaHD(startday, endday);
                gvHDBH.DataSource = listhd;
                gvHDBH.Columns[0].HeaderText = "Mã HD";
                gvHDBH.Columns[1].HeaderText = "Ngày lập HD";
                gvHDBH.Columns[2].HeaderText = "Mã NV";
                gvHDBH.Columns[3].HeaderText = "Mã KH";
                gvHDBH.Columns[4].HeaderText = "Thành tiền";
                gvHDBH.Columns[5].Visible = false;
                txtTongCong.Text = HoaDonBLL.DoanhThuTatCaHD(startday, endday).ToString();
            }
            else
            {
                bunifuSnackbarHDBH.Show(new frm_Quanly(user), "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                startday = DatePickerStartDay.Value;
                endday = DatePickerEndDay.Value;

                if (endday < startday)
                {
                    bunifuSnackbarHDBH.Show(new frm_Quanly(user), "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            catch (Exception)
            {
                bunifuSnackbarHDBH.Show(new frm_Quanly(user), "Vui lòng kiểm tra lại thời gian \nThời gian đã nhập không hợp lệ", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            DateTime sday = DatePickerStartDay.Value;
            DateTime eday = DatePickerEndDay.Value;
            frm_XemBaoCao frm = new frm_XemBaoCao();
            frm.rpt_HDBH_TatCaHD(sday, eday);
            frm.ShowDialog();
        }
    }
}
