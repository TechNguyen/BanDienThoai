﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BanDienThoai.Areas.Admin.Models
{
    public class ProductViewModel
    {
        public int MASP { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm")]
        public string TENSP { get; set; }
        [Required]
        public string HINHLON { get; set; }
        [Required]

		public string HINHNHO { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mô tả")]
        public string MOTA { get; set; }
        [Required]
        public string MATH { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đánh giá")]
        public string DANHGIA { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số lượng")]   
        public int SOLUONG { get; set; }
        [Required]
        public string MALOAISP { get; set; }
        [Required]
        public double DONGIA { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập trường này")]
        public string LOAISANPHAM { get; set; }
    }
}