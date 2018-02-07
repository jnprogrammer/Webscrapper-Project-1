namespace scrapper5
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CryptoContext : DbContext
    {
        public CryptoContext()
            : base("name=CryptoContext")
        {
        }

        public virtual DbSet<CryptoTable> CryptoTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CryptoTable>()
                .Property(e => e.CoinSymbol)
                .IsFixedLength();
        }
    }
}
