﻿using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class NhanVienDAL
    {
        public static NhanVienDTO GetEmployee(string manguoidung)
        {
            CHDTEntities entities = new CHDTEntities();
            NhanVien emp = (from nv in entities.NhanViens
                            where nv.MaNguoiDung == manguoidung
                            select nv).SingleOrDefault();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
            var mapper = new Mapper(config);
            NhanVienDTO nhanVien = mapper.Map<NhanVienDTO>(emp);
            return nhanVien;
        }

        public static NhanVienDTO GetEmployeeById(string manv)
        {
            CHDTEntities entities = new CHDTEntities();
            NhanVien emp = entities.NhanViens.Where(x => x.MaNV.Equals(manv)).Single();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
            var mapper = new Mapper(config);
            NhanVienDTO empDTO = mapper.Map<NhanVienDTO>(emp);
            return empDTO;
        }

        public static List<object> GetEmployeeByName(string name)
        {
            CHDTEntities entities = new CHDTEntities();
            List<object> list = new List<object>();

            var query = from nv in entities.NhanViens
                        join lnv in entities.LoaiNhanViens
                        on nv.MaLoaiNV equals lnv.MaLoaiNV
                        join tk in entities.TaiKhoans
                        on nv.MaNguoiDung equals tk.MaNguoiDung
                        where nv.TenNV.Contains(name) && nv.TrangThai == "1"
                        select new
                        {
                            nv.MaNV,
                            nv.TenNV,
                            nv.GioiTinh,
                            nv.Email,
                            nv.SĐT,
                            nv.DiaChi,
                            lnv.TenLoaiNV,
                            tk.UserName,
                        };

            foreach (var item in query)
            {
                list.Add(item);
            }
            return list;
        }

        public static List<object> GetAllEmployee()
        {
            CHDTEntities entities = new CHDTEntities();
            List<object> list = new List<object>();

            var query = from nv in entities.NhanViens
                        join lnv in entities.LoaiNhanViens
                        on nv.MaLoaiNV equals lnv.MaLoaiNV
                        join tk in entities.TaiKhoans
                        on nv.MaNguoiDung equals tk.MaNguoiDung
                        where nv.TrangThai == "1"
                        select new
                        {
                            nv.MaNV,
                            nv.TenNV,
                            nv.GioiTinh,
                            nv.Email,
                            nv.SĐT,
                            nv.DiaChi,
                            lnv.TenLoaiNV,
                            tk.UserName,
                        };

            foreach (var item in query)
            {
                list.Add(item);
            }
            return list;
        }

        public static bool AddEmployee(NhanVienDTO nvDTO)
        {
            CHDTEntities entities = new CHDTEntities();

            var query = (from x in entities.NhanViens
                         select x).Count();

            nvDTO.MaNV = "NV" + (query + 1).ToString("000");
            nvDTO.TrangThai = "1";

            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVienDTO, NhanVien>());
            var mapper = new Mapper(config);
            NhanVien nv = mapper.Map<NhanVien>(nvDTO);
            entities.NhanViens.Add(nv);

            try
            {
                entities.SaveChanges();
                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        public static bool UpdateEmployee(NhanVienDTO empDTO)
        {
            CHDTEntities entities = new CHDTEntities();
            NhanVien emp = entities.NhanViens.Where(x => x.MaNV.Equals(empDTO.MaNV)).Single();

            emp.TenNV = empDTO.TenNV;
            emp.GioiTinh = empDTO.GioiTinh;
            emp.Email = empDTO.Email;
            emp.DiaChi = empDTO.DiaChi;
            emp.SĐT = empDTO.SĐT;

            try
            {
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<NhanVienDTO> LayTatCaNhanVien()
        {
            CHDTEntities entities = new CHDTEntities();
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            var nhanvien = from nv in entities.NhanViens
                           select nv;
            foreach (NhanVien nv in nhanvien)
            {
                NhanVienDTO dto = new NhanVienDTO();
                dto.TenNV = nv.TenNV;
                dto.GioiTinh = nv.GioiTinh;
                dto.Email = nv.Email;
                dto.SĐT = nv.SĐT;
                dto.DiaChi = nv.DiaChi;
                list.Add(dto);
            }
            return list;
        }

        public static int CountEmployee()
        {
            CHDTEntities data = new CHDTEntities();
            var nhanvien = (from nv in data.NhanViens
                           select nv).Count();
            return nhanvien + 1;
        }
    }

}
