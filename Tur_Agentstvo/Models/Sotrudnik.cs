namespace Tur_Agentstvo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sotrudnik")]
    public partial class Sotrudnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sotrudnik()
        {
            Tur = new HashSet<Tur>();
        }

        [Key]
        public int ID_Sotrudnika { get; set; }

        [Required]
        [StringLength(50)]
        public string Familia { get; set; }

        [Required]
        [StringLength(50)]
        public string Imya { get; set; }

        [StringLength(50)]
        public string Otchestvo { get; set; }

        [Required]
        [StringLength(15)]
        public string Contactniy_telephone { get; set; }

        public int ID_Doljnost { get; set; }

        public int ID_Avtorizacii { get; set; }

        public virtual Avtorizacia Avtorizacia { get; set; }

        public virtual Doljnost Doljnost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tur> Tur { get; set; }
    }
}
