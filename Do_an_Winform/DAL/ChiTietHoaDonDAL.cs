﻿using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class ChiTietHoaDonDAL
    {
        public static bool AddNewBillDetail(ChiTietHoaDonDTO chitiethd)
        {
            CHDTEntities data = new CHDTEntities();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ChiTietHoaDonDTO, ChiTietHoaDon>());
            var mapper = new Mapper(config);
            ChiTietHoaDon chiTietHD = mapper.Map<ChiTietHoaDon>(chitiethd);
            data.ChiTietHoaDons.Add(chiTietHD);
            return data.SaveChanges() > 0 ? true : false;
        }
        public static List<ChiTietHoaDonDTO> GetAllDetailBillById(string maHD)
        {
            CHDTEntities entities = new CHDTEntities();
            var detailBills = from cthd in entities.ChiTietHoaDons
                              where cthd.TrangThai == "1" && cthd.MaHD == maHD
                              select cthd;
            List<ChiTietHoaDonDTO> CTHDDTOs = new List<ChiTietHoaDonDTO>();
            foreach (ChiTietHoaDon detailbill in detailBills)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<ChiTietHoaDon, ChiTietHoaDonDTO>());
                var mapper = new Mapper(config);
                ChiTietHoaDonDTO cthd = mapper.Map<ChiTietHoaDonDTO>(detailbill);
                CTHDDTOs.Add(cthd);
            }
            return CTHDDTOs;
        }
        public static List<ChiTietHoaDonDTO> GetAllDetailBill()
        {
            CHDTEntities entities = new CHDTEntities();
            var detailBills = from cthd in entities.ChiTietHoaDons
                              where cthd.TrangThai == "1"
                              select cthd;
            List<ChiTietHoaDonDTO> CTHDDTOs = new List<ChiTietHoaDonDTO>();
            foreach (ChiTietHoaDon pro in detailBills)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<ChiTietHoaDon, ChiTietHoaDonDTO>());
                var mapper = new Mapper(config);
                ChiTietHoaDonDTO sanpham = mapper.Map<ChiTietHoaDonDTO>(pro);
                CTHDDTOs.Add(sanpham);
            }
            return CTHDDTOs;
        }
    }
}
