using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DTO
{
    public class Sach
    {
        public int MaSach { get; set; }
        public string TenSach {  get; set; }
        public DateTime NamSanXuat { get; set; }
        public decimal Gia {  get; set; }
        public string Poster { get; set; }                                                                                  
        public string MaLoaiSach {  get; set; }
        public int SoLuong { get; set; }

        public Sach() { }

        public Sach(int maSach, string tenSach, DateTime namSanXuat, int gia, string poster, string maLoaiSach, int soLuong)
        {
            this.MaSach = maSach;
            this.TenSach = tenSach;
            this.NamSanXuat = namSanXuat;
            this.Gia = gia;
            this.Poster = poster;
            this.MaLoaiSach = maLoaiSach;
            this.SoLuong = soLuong;
        }

        public int getMaSach() { return this.MaSach; }
        public string getTenSach() { return this.TenSach;  }
        public DateTime getNamSanXuat() { return this.NamSanXuat; }
        public decimal getGia() {  return this.Gia; }
        public string getPoster() { return this.Poster; }
        public string getMaLoaiSach() { return this.MaLoaiSach; }
        public int getSoLuong() { return this.SoLuong; }

        public void setMaSach(int MaSach)
        {
            this.MaSach = MaSach;
        }
        public void setTenSach(string TenSach)
        {
            this.TenSach = TenSach;
        }
        public void setNamSanXuat(DateTime NamSanXuat)
        {
            this.NamSanXuat = NamSanXuat;
        }
        public void setGia(decimal Gia)
        {
            this.Gia = Gia;
        }
        public void setPoster(string Poster)
        {
            this.Poster = Poster;
        }
        public void setMaLoaiSach(string MaLoaiSach)
        {
            this.MaLoaiSach = MaLoaiSach;
        }
        public void setSoLuong(int SoLuong)
        {
            this.SoLuong = SoLuong;
        }

    }
}
