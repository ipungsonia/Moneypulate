namespace Moneypulate
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catatan")]
    public partial class Catatan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        public decimal Penghasilan { get; set; }

        public decimal Pengeluaran { get; set; }

        public decimal DanaDarurat { get; set; }

        public decimal DanaInvestasi { get; set; }
    }
}
