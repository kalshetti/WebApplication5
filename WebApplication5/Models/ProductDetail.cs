using System;
using System.Collections.Generic;

namespace WebApplication5.Models;

public partial class ProductDetail
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? CategoryId { get; set; }

    public string? CategoryName { get; set; }
}
