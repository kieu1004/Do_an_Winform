﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
	public class HoaDonDTO
	{
		private string _MaHD;
		private DateTime _NgayTaoHD;
		private string _MaNV;
		private string _MaKH;
		private string _TrangThai;

		public string MaHD
		{
			get { return _MaHD; }
			set { _MaHD = value; }
		}
		public DateTime NgayTaoHD
		{
			get { return _NgayTaoHD; }
			set { _NgayTaoHD = value; }
		}
		public string MaNV
		{
			get { return _MaNV; }
			set { _MaNV = value; }
		}
		public string MaKH
		{
			get { return _MaKH; }
			set { _MaKH = value; }
		}

		private int _ThanhTien;
		public int ThanhTien
		{
			get { return _ThanhTien; }
			set { _ThanhTien = value; }
		}

		public string TrangThai
        {
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}

		public HoaDonDTO(string MaHD_, DateTime NgayTaoHD_, string MaNV_, string MaKH_,int ThanhTien_, string TrangThai_)
		{
			this.MaHD = MaHD_;
			this.NgayTaoHD = NgayTaoHD_;
			this.MaNV = MaNV_;
			this.MaKH = MaKH_;
			this.ThanhTien = ThanhTien_;
			this.TrangThai = TrangThai_;
		}
		public HoaDonDTO()
		{
			this.MaHD = "";
			this.NgayTaoHD = DateTime.Now;
			this.MaNV = "";
			this.MaKH = "";
			this.ThanhTien = 0;
			this.TrangThai = "";
		}
	}
}