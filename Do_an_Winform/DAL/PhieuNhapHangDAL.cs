﻿using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    class PhieuNhapHangDAL
    {
        public static List<PhieuNhapHangDTO> ThongKeTatCaPN(DateTime startday, DateTime endday)
        {
            CHDTEntities data = new CHDTEntities();
            var truyvan = from pn in data.PhieuNhapHangs
                          where pn.TrangThai == "1" && (pn.NgayTaoPN >= startday) && (pn.NgayTaoPN <= endday)
                          select pn;
            List<PhieuNhapHangDTO> listpn = new List<PhieuNhapHangDTO>();
            foreach (PhieuNhapHang pn in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuNhapHang, PhieuNhapHangDTO>());
                var mapper = new Mapper(config);
                PhieuNhapHangDTO phieunhap = mapper.Map<PhieuNhapHangDTO>(pn);
                listpn.Add(phieunhap);
            }
            return listpn;
        }
        public static List<PhieuNhapHangDTO> TKTheoMaPN(string pnsearch, DateTime today)
        {
            CHDTEntities data = new CHDTEntities();
            var truyvan = from pn in data.PhieuNhapHangs
                          where (pn.MaPN == pnsearch) && (pn.TrangThai == "1") && (pn.NgayTaoPN <= today)
                          select pn;
            List<PhieuNhapHangDTO> listpn = new List<PhieuNhapHangDTO>();
            foreach (PhieuNhapHang pn in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuNhapHang, PhieuNhapHangDTO>());
                var mapper = new Mapper(config);
                PhieuNhapHangDTO pndto = mapper.Map<PhieuNhapHangDTO>(pn);
                listpn.Add(pndto);
            }
            return listpn;
        }
        public static PhieuNhapHangDTO LayTheoMaPN(string mapn)
        {
            CHDTEntities entities = new CHDTEntities();
            PhieuNhapHang truyvan = (from pn in entities.PhieuNhapHangs
                                     where pn.MaPN == mapn && pn.TrangThai == "1"
                                     select pn).SingleOrDefault();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuNhapHang, PhieuNhapHangDTO>());
            var mapper = new Mapper(config);
            PhieuNhapHangDTO pnhap = mapper.Map<PhieuNhapHangDTO>(truyvan);
            return pnhap;
        }
        public static List<object> LayTatCaMaPN()
        {
            CHDTEntities data = new CHDTEntities();
            List<object> list = new List<object>();
            var truyvan = from pn in data.PhieuNhapHangs
                          where pn.TrangThai == "1"
                          select pn.MaPN;
            foreach (var item in truyvan)
            {
                list.Add(item);
            }
            return list;
        }
        public static double ChiPhiTatCaPN(DateTime startday, DateTime endday)
        {
            CHDTEntities data = new CHDTEntities();
            var truyvan = from pn in data.PhieuNhapHangs
                          where (pn.NgayTaoPN >= startday) && (pn.NgayTaoPN <= endday) && (pn.TrangThai == "1")
                          select new
                          {
                              pn.ThanhTien
                          };

            double reusultDT = 0;
            foreach (var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }
        public static double ChiPhiTheoMaPN(string pnsearch, DateTime today)
        {
            CHDTEntities data = new CHDTEntities();
            var truyvan = from pn in data.PhieuNhapHangs
                          where (pn.MaPN == pnsearch) && (pn.NgayTaoPN <= today) && (pn.TrangThai == "1")
                          select new
                          {
                              pn.ThanhTien
                          };

            double reusultDT = 0;
            foreach (var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }
        public static double ThongKeChiPhiTheoTDHT(DateTime today)
        {
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);

            CHDTEntities data = new CHDTEntities();
            var truyvan = from hd in data.PhieuNhapHangs
                          where (hd.NgayTaoPN >= firstDayOfMonth) && (hd.NgayTaoPN <= today) && (hd.TrangThai == "1")
                          select new
                          {
                              hd.ThanhTien
                          };
            double reusultDT = 0;
            foreach (var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }
        public static double ThongKeChiPhiTheoNam(string namTK)
        {
            var firstDayOfMonth = GetLastDayOfMonth("1", namTK);
            var lastDayOfMonth = GetLastDayOfMonth("12", namTK);
            CHDTEntities data = new CHDTEntities();
            var truyvan = from pn in data.PhieuNhapHangs
                          where (pn.NgayTaoPN >= firstDayOfMonth) && (pn.NgayTaoPN <= lastDayOfMonth) && (pn.TrangThai == "1")
                          select new
                          {
                              pn.ThanhTien
                          };
            double reusultDT = 0;
            foreach (var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }
        public static double ThongKeChiPhiTheoQuy(string quyTK, string namTK)
        {
            DateTime firstDayOfMonth;
            DateTime lastDayOfMonth;

            double reusultDT = 0;
            if (quyTK == "1")
            {
                firstDayOfMonth = GetFirstDayOfMonth("1", namTK);
                lastDayOfMonth = GetLastDayOfMonth("3", namTK);
                CHDTEntities data = new CHDTEntities();
                var truyvan = from pn in data.PhieuNhapHangs
                              where (pn.NgayTaoPN >= firstDayOfMonth) && (pn.NgayTaoPN <= lastDayOfMonth) && (pn.TrangThai == "1")
                              select new
                              {
                                  pn.ThanhTien
                              };
                foreach (var i in truyvan)
                {
                    reusultDT += i.ThanhTien;
                };
            }
            if (quyTK == "2")
            {
                firstDayOfMonth = GetFirstDayOfMonth("4", namTK);
                lastDayOfMonth = GetLastDayOfMonth("6", namTK);
                CHDTEntities data = new CHDTEntities();
                var truyvan = from pn in data.PhieuNhapHangs
                              where (pn.NgayTaoPN >= firstDayOfMonth) && (pn.NgayTaoPN <= lastDayOfMonth) && (pn.TrangThai == "1")
                              select new
                              {
                                  pn.ThanhTien
                              };
                foreach (var i in truyvan)
                {
                    reusultDT += i.ThanhTien;
                };
            }
            if (quyTK == "3")
            {
                firstDayOfMonth = GetFirstDayOfMonth("7", namTK);
                lastDayOfMonth = GetLastDayOfMonth("9", namTK);
                CHDTEntities data = new CHDTEntities();
                var truyvan = from pn in data.PhieuNhapHangs
                              where (pn.NgayTaoPN >= firstDayOfMonth) && (pn.NgayTaoPN <= lastDayOfMonth) && (pn.TrangThai == "1")
                              select new
                              {
                                  pn.ThanhTien
                              };
                foreach (var i in truyvan)
                {
                    reusultDT += i.ThanhTien;
                };
            }
            if (quyTK == "4")
            {
                firstDayOfMonth = GetFirstDayOfMonth("10", namTK);
                lastDayOfMonth = GetLastDayOfMonth("12", namTK);
                CHDTEntities data = new CHDTEntities();
                var truyvan = from pn in data.PhieuNhapHangs
                              where (pn.NgayTaoPN >= firstDayOfMonth) && (pn.NgayTaoPN <= lastDayOfMonth) && (pn.TrangThai == "1")
                              select new
                              {
                                  pn.ThanhTien
                              };
                foreach (var i in truyvan)
                {
                    reusultDT += i.ThanhTien;
                };
            }

            return reusultDT;
        }
        public static double ThongKeChiPhiTheoThang(string thangTK, string namTK)
        {
            DateTime firstDayOfMonth = GetLastDayOfMonth(thangTK, namTK);
            CHDTEntities data = new CHDTEntities();
            var truyvan = from pn in data.PhieuNhapHangs
                          where pn.NgayTaoPN.Month.Equals(firstDayOfMonth.Month) && (pn.NgayTaoPN.Year.Equals(firstDayOfMonth.Year)) && (pn.TrangThai == "1")
                          select new
                          {
                              pn.ThanhTien
                          };
            double reusultDT = 0;
            foreach (var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }
        //Hàm lấy ra ngày đầu tiên của tháng
        public static DateTime GetFirstDayOfMonth(string strMonth, string strYear)
        {
            int iMonth = int.Parse(strMonth);
            int iYear = int.Parse(strYear);
            DateTime dtResult = new DateTime(iYear, iMonth, 1);
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }
        //Hàm lấy ra ngày cuối cùng của tháng
        public static DateTime GetLastDayOfMonth(string strMonth, string strYear)
        {
            int iMonth = int.Parse(strMonth);
            int iYear = int.Parse(strYear);
            DateTime dtResult = new DateTime(iYear, iMonth, 1);
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        // Thêm Phiếu nhập
        public static bool AddPhieuNhap(PhieuNhapHangDTO phieuNhapHangDTO)
        {
            CHDTEntities entities = new CHDTEntities();
            phieuNhapHangDTO.TrangThai = "1";

            var config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuNhapHangDTO, PhieuNhapHang>());
            var mapper = new Mapper(config);
            PhieuNhapHang pn = mapper.Map<PhieuNhapHang>(phieuNhapHangDTO);
            entities.PhieuNhapHangs.Add(pn);

            return entities.SaveChanges() > 0 ? true : false;
        }
        // Lấy mã Phiếu nhập
        public static string CountMaPN()
        {
            CHDTEntities entities = new CHDTEntities();

            var query = (from x in entities.PhieuNhapHangs
                         select x).Count();
            string count = "PN" + (query + 1).ToString("000");
            return count;
        }
        // Lấy tất cả 
        public static List<PhieuNhapHangDTO> GetAll()
        {
            CHDTEntities entities = new CHDTEntities();
            var query = from pn in entities.PhieuNhapHangs
                        where pn.TrangThai == "1"
                        select pn;
            List<PhieuNhapHangDTO> phieuNhaps = new List<PhieuNhapHangDTO>();
            foreach (PhieuNhapHang item in query)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuNhapHang, PhieuNhapHangDTO>());
                var mapper = new Mapper(config);
                PhieuNhapHangDTO phieuNhap = mapper.Map<PhieuNhapHangDTO>(item);
                phieuNhaps.Add(phieuNhap);
            }
            return phieuNhaps;
        }

        public static Dictionary<int, double> GetCostByMonth(DateTime time)
        {
            CHDTEntities entities = new CHDTEntities();

            var query = from hd in entities.HoaDons
                        where hd.TrangThai == "1" && hd.NgayTaoHD.Day.Equals(time.Day) && hd.NgayTaoHD.Month.Equals(time.Month) && hd.NgayTaoHD.Year.Equals(time.Year)
                        group hd by hd.NgayTaoHD.Day into table
                        select new
                        {
                            Key = table.Key,
                            Value = table.Sum(t => t.ThanhTien)
                         };

            Dictionary<int, double> list = new Dictionary<int, double>();
            foreach (var item in query)
            {
                list.Add(item.Key, item.Value);
            }
            return list;
        }

        public static Dictionary<int, double> GetCostByThisMonth(DateTime time)
        {
            CHDTEntities entities = new CHDTEntities();

            var query = from pn in entities.PhieuNhapHangs
                        where pn.TrangThai == "1" && pn.NgayTaoPN.Month.Equals(time.Month) && pn.NgayTaoPN.Year.Equals(time.Year)
                        group pn by pn.NgayTaoPN.Day into table
                        select new
                        {
                            Key = table.Key,
                            Value = table.Sum(t => t.ThanhTien)
                        };

            Dictionary<int, double> list = new Dictionary<int, double>();
            foreach (var item in query.OrderBy(t => t.Key))
            {
                list.Add(item.Key, item.Value);
            }
            return list;
        }

        public static Dictionary<int, double> GetCostByThisYear(DateTime time)
        {
            CHDTEntities entities = new CHDTEntities();

            var query = from pn in entities.PhieuNhapHangs
                        where pn.TrangThai == "1" && pn.NgayTaoPN.Year.Equals(time.Year)
                        group pn by pn.NgayTaoPN.Day into table
                        select new
                        {
                            Key = table.Key,
                            Value = table.Sum(t => t.ThanhTien)
                        };

            Dictionary<int, double> list = new Dictionary<int, double>();
            foreach (var item in query.OrderBy(t => t.Key))
            {
                list.Add(item.Key, item.Value);
            }
            return list;
        }
    }
}
