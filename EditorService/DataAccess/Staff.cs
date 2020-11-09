namespace EditorService.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }

        public int? Id_Gender { get; set; }

        public int Id_Role { get; set; }

        [Required]
        [StringLength(11)]
        public string Personal_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birth_Date { get; set; }

        public int? Id_Country { get; set; }

        public int? Id_City { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(255)]
        public string AccountPassword { get; set; }

        public virtual City City { get; set; }

        public virtual Country Country { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual Role Role { get; set; }
    }
}
