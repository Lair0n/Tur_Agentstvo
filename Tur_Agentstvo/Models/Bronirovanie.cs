namespace Tur_Agentstvo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bronirovanie")]
    public partial class Bronirovanie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Bronirovania { get; set; }

        public int ID_Clienta { get; set; }

        public int ID_Tura { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data_broni { get; set; }

        public virtual Client Client { get; set; }

        public virtual Tur Tur { get; set; }
    }
}
