namespace scrapper5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CryptoTable")]
    public partial class CryptoTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CoinName { get; set; }

        [Required]
        [StringLength(10)]
        public string CoinSymbol { get; set; }

        public long MarketCap { get; set; }

        public int Price { get; set; }

        [Column("Circulating Supply ")]
        public long Circulating_Supply_ { get; set; }

        public long Volume24hr { get; set; }
    }
}
