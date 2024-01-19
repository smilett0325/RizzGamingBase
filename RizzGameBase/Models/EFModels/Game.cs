namespace RizzGameBase.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Game
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Game()
        {
            DLCs = new HashSet<DLC>();
            DLCs1 = new HashSet<DLC>();
            GameTags = new HashSet<GameTag>();
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Introduction { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(200)]
        public string Image { get; set; }

        public int DeveloperId { get; set; }

        public int GameTagId { get; set; }

        public int? DiscountId { get; set; }

        public int? MaxPersent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DLC> DLCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DLC> DLCs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameTag> GameTags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }
    }
}