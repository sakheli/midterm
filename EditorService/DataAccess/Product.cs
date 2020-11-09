namespace EditorService.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Authors = new HashSet<Author>();
        }

        public int Id { get; set; }

        public int? Unique_Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public int? Id_ProductType { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        [Column(TypeName = "date")]
        public DateTime Publish_Date { get; set; }

        public int? Id_PublishingHouse { get; set; }

        public int? Pages { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public virtual ProductType ProductType { get; set; }

        public virtual Publishing_House Publishing_House { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Author> Authors { get; set; }
    }
}
