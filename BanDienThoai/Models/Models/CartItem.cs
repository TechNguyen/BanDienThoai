﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BanDienThoai.Domain.DataContext;

namespace BanDienThoai.Models.Models
{
    public class CartItem
    {
        public SANPHAM Product { get; set; }
        public int Quantity { get; set; }
        public int Promotion { get; set; }
    }
}