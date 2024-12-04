using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung
    {
        public int MaND {  get; set; }
        public string Username {  get; set; }
        public string Pass { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NamSinh { get; set; }
        public string GioiTinh {  get; set; }
        public string DiaChi {  get; set; }
        public string SoDienThoai { get; set; }
        public int MaQuyen {  get; set; }
        public NguoiDung() { }

        public NguoiDung(int maND, string username, string pass, string hoVaTen, DateTime namSinh, string gioiTinh, string diaChi, string soDienThoai, int maQuyen)
        {
            this.MaND = maND;
            this.Username = username;
            this.Pass = pass;
            this.HoVaTen = hoVaTen;
            this.NamSinh = namSinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
            this.MaQuyen = maQuyen;
        }


        //sự kiện lấy ra thông tin người dùng
        public int getMaND() { return this.MaND; }
        public string getUsername() { return this.Username; }
        public string getPass() {  return this.Pass; }
        public string getHoVaTen() { return this.HoVaTen; }
        public DateTime getNamSinh() { return this.NamSinh; }
        public string getGioiTinh() {  return this.GioiTinh;}
        public string getDiaChi() { return this.DiaChi; }
        public string getSoDienThoai() {  return this.SoDienThoai;}
        public int getMaQuyen() { return this.MaQuyen; }
        
        public void setMaND(int MaND)
        {
            this.MaND = MaND;
        }
        public void setUsername(string Username)
        {
            this.Username = Username;
        }
        public void setPass(string Pass) {
            this.Pass = Pass; 
        }
        public void setHoVaTen(string HoVaTen)
        {
            this.HoVaTen = HoVaTen;
        }
        public void setNamSinh(DateTime NamSinh)
        {
            this.NamSinh = NamSinh;
        }
        public void setGioiTinh(string GioiTinh)
        {
            this.GioiTinh = GioiTinh;
        }
        public void setDiaChi(string DiaChi)
        {
            this.DiaChi = DiaChi;
        }
        public void setSoDienThoai(string SoDienThoai)
        {
            this.SoDienThoai = SoDienThoai;
        }
        public void setMaQuyen(int MaQuyen)
        {
            this.MaQuyen = MaQuyen;
        }
    }
}
