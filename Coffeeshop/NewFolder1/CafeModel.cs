namespace Coffeeshop.NewFolder1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CafeModel : DbContext
    {
        public CafeModel()
            : base("name=CafeModel")
        {
        }

        public virtual DbSet<MENU> MENUS { get; set; }
        public virtual DbSet<nguyenlieu> nguyenlieux { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
