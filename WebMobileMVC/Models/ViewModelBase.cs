using System;
namespace WebMobileMVC.Models
{
    public class ViewModelBase
    {
        public KhachHang khachHang { get; set; } = Helpers.ApiHelper.Get<KhachHang>(Helpers.ConstantVariable.URLBase.baseUrl + "khachhang/getinfo");
        public System.Collections.Generic.List<CartViewModel> carts = Helpers.ConstantVariable.dsSanPham.Count == 0 ? null : Helpers.ConstantVariable.dsSanPham;
    }
}
