namespace Tur_Agentstvo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tur")]
    public partial class Tur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tur()
        {
            Bronirovanie = new HashSet<Bronirovanie>();
            Otzivy = new HashSet<Otzivy>();
            Sotrudnik = new HashSet<Sotrudnik>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Tura { get; set; }

        [Required]
        [StringLength(50)]
        public string Mesto_tura { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data_nachala { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data_konca { get; set; }

        public int stoimosti { get; set; }

        public int ID_Sotrudnika { get; set; }

        public int ID_Avtorizacii { get; set; }

        public virtual Avtorizacia Avtorizacia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bronirovanie> Bronirovanie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Otzivy> Otzivy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sotrudnik> Sotrudnik { get; set; }
    }
}
