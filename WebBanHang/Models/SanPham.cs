//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        public int ID { get; set; }
        public string TenSP { get; set; }
        public Nullable<int> GiaBan { get; set; }
        public Nullable<int> GiaCu { get; set; }
        public string New_Hot { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
        public Nullable<int> SoLuongBan { get; set; }
        public Nullable<int> SoLuotDanhGia { get; set; }
        public Nullable<int> IdLoaiSP { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string MoTa { get; set; }
    
        public virtual TheLoai TheLoai { get; set; }
    }
}
