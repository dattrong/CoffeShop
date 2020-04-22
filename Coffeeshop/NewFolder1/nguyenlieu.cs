namespace Coffeeshop.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nguyenlieu")]
    public partial class nguyenlieu
    {
        public int nguyenLieuId { get; set; }

        [StringLength(50)]
        public string tenNguyenLieu { get; set; }

        public int? menuId { get; set; }
    }
}
