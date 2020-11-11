namespace EditorService.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Users")]
    public partial class User
    {
        public int Id { get; set; }

        public int Id_Role { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Password { get; set; }

        public virtual Role Role { get; set; }
    }
}
