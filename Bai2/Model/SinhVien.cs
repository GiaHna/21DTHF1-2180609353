namespace Bai2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [StringLength(20)]
        public string MaSV { get; set; }

        [StringLength(20)]
        public string HoTen { get; set; }

        public double? DiemTb { get; set; }

        public int? MaKhoa { get; set; }

        public virtual Khoa Khoa { get; set; }
    }
}
