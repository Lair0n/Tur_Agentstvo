namespace Tur_Agentstvo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doljnost")]
    public partial class Doljnost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doljnost()
        {
            Sotrudnik = new HashSet<Sotrudnik>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Doljnost { get; set; }

        [Column("Doljnost")]
        [Required]
        [StringLength(50)]
        public string Doljnost1 { get; set; }

        public int Zarplata { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sotrudnik> Sotrudnik { get; set; }
    }
}
