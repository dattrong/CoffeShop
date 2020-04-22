namespace Coffeeshop.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MENUS")]
    public partial class MENU
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? money { get; set; }

        public List<nguyenlieu> tennguyenlieu { get; set; }
    }
}
