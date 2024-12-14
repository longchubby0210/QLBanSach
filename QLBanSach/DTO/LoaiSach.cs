using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSach
    {
        public string MaLoaiSach { get; set; }
        public string TenLoaiSach { get; set; }
        public LoaiSach() { }

        public LoaiSach(string maLoaiSach, string tenLoaiSach)
        {
            this.MaLoaiSach = maLoaiSach;
            this.TenLoaiSach = tenLoaiSach;
        }
        public string getMaLoaiSach()  { return this.MaLoaiSach; }
        public string getTenLoaiSach() { return this.TenLoaiSach; }
        public void setMaLoaiSach(string MaLoaiSach)
        {
            this.MaLoaiSach = MaLoaiSach;
        }
        public void setTenLoaiSach(string TenLoaiSach)
        {
            this.TenLoaiSach= TenLoaiSach;
        }
    }
}
