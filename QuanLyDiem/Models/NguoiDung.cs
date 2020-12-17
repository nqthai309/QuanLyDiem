namespace QuanLyDiem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [Key]
        [StringLength(250)]
        public string TenDangNhap { get; set; }

        [StringLength(250)]
        public string MatKhau { get; set; }
    }
}
