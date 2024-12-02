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
        public string MaND {  get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NamSinh { get; set; }
        public string GioiTinh {  get; set; }
        public string DiaChi {  get; set; }
        public string SoDienThoai { get; set; }

    }
}
